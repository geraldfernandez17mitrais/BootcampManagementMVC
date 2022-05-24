using AutoFixture;
using AutoMapper;
using BootcampManagementMVC.BL.Dtos.BootcampGroups;
using BootcampManagementMVC.BL.Helpers;
using BootcampManagementMVC.BL.Services;
using BootcampManagementMVC.DA.Interfaces;
using BootcampManagementMVC.Domain.Models;
using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BootcampManagementMVC.UnitTests.Services
{
    public class BootcampGroupServiceTest
    {
        private readonly Mock<IBootcampGroupRepository> _mockBootcampGroupRepository;
        private readonly Mock<IUserBootcampRepository> _mockUserBootcampRepository;
        private readonly IMapper _mapper;
        private readonly BootcampGroupService _sut;
        private readonly Fixture fixture;

        private readonly BootcampGroupPostDto _bootcampGroupPostDto = new BootcampGroupPostDto()
        {
            Name = "Java Bootcamp",
            Description = "Bootcamp for Java",
            IsActive = true
        };

        private readonly BootcampGroupDto _bootcampGroupDto = new BootcampGroupDto()
        {
            Id = 2,
            Name = "DotNet Blazor Bootcamp",
            Description = "Bootcamp for Blazor DotNet",
            IsActive = true,
            SyllabusId = 2
        };

        private readonly BootcampGroupPutDto _bootcampGroupPutDto = new BootcampGroupPutDto()
        {
            Id = 2,
            Name = "DotNet Blazor Bootcamp",
            Description = "Bootcamp for Blazor DotNet",
            IsActive = true
        };

        private readonly IEnumerable<BootcampGroup> _bootcampGroupEmptyList = Enumerable.Empty<BootcampGroup>();

        public BootcampGroupServiceTest()
        {
            _mockBootcampGroupRepository = new Mock<IBootcampGroupRepository>();
            _mockUserBootcampRepository = new Mock<IUserBootcampRepository>();

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfiles());
            });

            _mapper = new Mapper(config);
            _sut = new BootcampGroupService(_mockBootcampGroupRepository.Object, _mockUserBootcampRepository.Object, _mapper);

            // auto fixture configure:
            fixture = new Fixture();
            fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        [Fact]
        public void ShouldMapper_MapBootcampGroupAllFields()
        {
            //arrange
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BootcampGroup, BootcampGroupDto>();
            });
            var mapper = config.CreateMapper();

            BootcampGroup _mockBootcampGroupModel = new BootcampGroup()
            {
                Id = 2,
                Name = "DotNet Blazor Bootcamp",
                Description = "Bootcamp for Blazor DotNet",
                IsActive = true,
                Syllabus = new Syllabus()
                {
                    Id = 2
                }
            };

            //act
            var result = mapper.Map<BootcampGroup, BootcampGroupDto>(_mockBootcampGroupModel);
            result.Should().BeEquivalentTo(_bootcampGroupDto);
        }

        [Fact]
        public void GetAsync_ListIsEmpty_ReturnEmptyList()
        {
            // Arrange
            _mockBootcampGroupRepository.Setup(c => c.GetAsync()).Returns(Task.FromResult(_bootcampGroupEmptyList));

            // Act
            IEnumerable<BootcampGroupDto> returnTask = _sut.GetAsync().Result;

            // Assert
            returnTask.Should().BeEmpty();
        }

        [Fact]
        public void GetAsync_ListIsNotEmpty_ReturnList()
        {
            // Arrange
            IEnumerable<BootcampGroup> _listBootcampGroup = fixture.CreateMany<BootcampGroup>().ToList();

            _mockBootcampGroupRepository.Setup(c => c.GetAsync()).Returns(Task.FromResult(_listBootcampGroup));

            // Act
            IEnumerable<BootcampGroupDto> returnTask = _sut.GetAsync().Result;

            // Assert
            returnTask.Should().NotBeEmpty();
            returnTask.Should().HaveCount(_listBootcampGroup.Count());
        }

        [Fact]
        public void GetWithTotalMembersAsync_ListIsEmpty_ReturnEmptyList()
        {
            // Arrange
            _mockBootcampGroupRepository.Setup(c => c.GetAsync()).Returns(Task.FromResult(_bootcampGroupEmptyList));

            // Act
            IEnumerable<BootcampGroupAndTotalMemberDto> returnTask = _sut.GetWithTotalMembersAsync().Result;

            // Assert
            returnTask.Should().BeEmpty();
        }

        [Fact]
        public void GetWithTotalMembersAsync_ListIsNotEmpty_ReturnList()
        {
            // Arrange
            IEnumerable<BootcampGroup> _listBootcampGroup = fixture.CreateMany<BootcampGroup>().ToList();
            IEnumerable<UserBootcamp> _listUserBootcamp = fixture.CreateMany<UserBootcamp>().ToList();
            IEnumerable<UserBootcamp> _listActiveMembers = fixture.CreateMany<UserBootcamp>().ToList();
            _listActiveMembers.Where(am => am.IsActive == false).ToList().ForEach(s => s.IsActive = true);
            _listActiveMembers.ToList().ForEach(am => am.BootcampGroupId = _listBootcampGroup.First().Id);

            _mockBootcampGroupRepository.Setup(c => c.GetAsync()).Returns(Task.FromResult(_listBootcampGroup));
            _mockUserBootcampRepository.Setup(c => c.GetAsync()).Returns(Task.FromResult(_listUserBootcamp));
            _mockUserBootcampRepository.Setup(c => c.GetActiveMembersAsync()).Returns(Task.FromResult(_listActiveMembers));

            // Act
            IEnumerable<BootcampGroupAndTotalMemberDto> returnTask = _sut.GetWithTotalMembersAsync().Result;

            // Assert
            returnTask.Should().NotBeEmpty();
            returnTask.Should().HaveCount(_listBootcampGroup.Count());
        }

        [Fact]
        public void AddAsync_BootcampNameIsExist_ThrowOneException()
        {
            // Arrange
            IEnumerable<BootcampGroup> _listBootcampGroup = fixture.CreateMany<BootcampGroup>().ToList();

            _mockBootcampGroupRepository.Setup(c => c.GetByNameAsync(_bootcampGroupPostDto.Name)).Returns(Task.FromResult(_listBootcampGroup.First()));

            // Act
            Task returnTask = _sut.AddAsync(_bootcampGroupPostDto);

            // Assert
            returnTask.Exception.InnerExceptions.Count().Should().Be(1);
            returnTask.Exception.InnerException.Message.Should().Be(ResponseCode.bootcampGroupAlreadyExist);
        }

        [Fact]
        public void UpdateAsync_IdNotFound_ThrowOneException()
        {
            // Arrange
            _mockBootcampGroupRepository.Setup(c => c.GetByIdAsync(_bootcampGroupPutDto.Id)).Returns(Task.FromResult<BootcampGroup>(null));

            // Act
            Task returnTask = _sut.UpdateAsync(_bootcampGroupPutDto.Id, _bootcampGroupPutDto);

            // Assert
            returnTask.Exception.InnerExceptions.Count().Should().Be(1);
            returnTask.Exception.InnerException.Message.Should().Be(ResponseCode.bootcampGroupNotFound);
        }

        [Fact]
        public void UpdateAsync_BootcampNameIsExist_ThrowOneException()
        {
            // Arrange
            IEnumerable<BootcampGroup> _listBootcampGroup = fixture.CreateMany<BootcampGroup>().ToList();
            _listBootcampGroup.Last().Id = _bootcampGroupPutDto.Id + 1;
            _listBootcampGroup.Last().Name = _bootcampGroupPutDto.Name;

            _mockBootcampGroupRepository.Setup(c => c.GetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(_listBootcampGroup.First()));
            _mockBootcampGroupRepository.Setup(c => c.GetByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(_listBootcampGroup.Last()));

            // Act
            Task returnTask = _sut.UpdateAsync(_bootcampGroupPutDto.Id, _bootcampGroupPutDto);

            // Assert
            returnTask.Exception.InnerExceptions.Count().Should().Be(1);
            returnTask.Exception.InnerException.Message.Should().Be(ResponseCode.bootcampGroupAlreadyExist);
        }

        [Fact]
        public void UpdateAsync_SetToInactiveAndAnyMemberIsStillJoining_ThrowOneException()
        {
            // Arrange
            IEnumerable<BootcampGroup> _listBootcampGroup = fixture.CreateMany<BootcampGroup>().ToList();
            IEnumerable<UserBootcamp> _listActiveMembersByBootcampGroupId = fixture.CreateMany<UserBootcamp>().ToList();

            _bootcampGroupPutDto.IsActive = false;
            _listBootcampGroup.Last().Id = _bootcampGroupPutDto.Id;
            _listBootcampGroup.Last().Name = _bootcampGroupPutDto.Name;
            _listActiveMembersByBootcampGroupId.ToList().ForEach(am => am.BootcampGroupId = _listBootcampGroup.First().Id);

            _mockBootcampGroupRepository.Setup(c => c.GetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(_listBootcampGroup.First()));
            _mockBootcampGroupRepository.Setup(c => c.GetByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(_listBootcampGroup.Last()));
            _mockUserBootcampRepository.Setup(c => c.GetActiveMembersByBootcampGroupIdAsync(_listBootcampGroup.First().Id)).Returns(Task.FromResult(_listActiveMembersByBootcampGroupId));

            // Act
            Task returnTask = _sut.UpdateAsync(_bootcampGroupPutDto.Id, _bootcampGroupPutDto);

            // Assert
            returnTask.Exception.InnerExceptions.Count().Should().Be(1);
            returnTask.Exception.InnerException.Message.Should().Be(ResponseCode.bootcampGroupCannotBeChangedToInactive);
        }

        [Fact]
        public void DeleteAsync_BootcampGroupNotFound_ThrowOneException()
        {
            // Arrange
            _mockBootcampGroupRepository.Setup(c => c.GetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<BootcampGroup>(null));

            // Act
            Task returnTask = _sut.DeleteAsync(It.IsAny<int>());

            // Assert
            returnTask.Exception.InnerExceptions.Count().Should().Be(1);
            returnTask.Exception.InnerException.Message.Should().Be(ResponseCode.bootcampGroupNotFound);
        }
    }
}