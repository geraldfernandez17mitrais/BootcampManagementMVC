using AutoMapper;
using BootcampManagementMVC.BL.Interfaces;
using BootcampManagementMVC.BL.ViewModels.BootcampGroups;
using BootcampManagementMVC.DA.Interfaces;
using BootcampManagementMVC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.BL.Services
{
    public class BootcampGroupService : IBootcampGroupService
    {
        private readonly IBootcampGroupRepository _repoBootcampGroup;
        private readonly IUserBootcampRepository _repoUserBootcamp;
        private readonly IMapper _mapper;

        public BootcampGroupService(IBootcampGroupRepository repoBootcampGroup, IUserBootcampRepository repoUserBootcamp, IMapper mapper)
        {
            _repoBootcampGroup = repoBootcampGroup;
            _repoUserBootcamp = repoUserBootcamp;
            _mapper = mapper;
        }

        //public async Task AddAsync(BootcampGroupPostDto bootcampGroupPostDto)
        //{
        //    // convert from dto object to model object:
        //    BootcampGroup bootcampGroup = _mapper.Map<BootcampGroupPostDto, BootcampGroup>(bootcampGroupPostDto);

        //    // add syllabus data to bootcamp:
        //    Syllabus syllabus = new Syllabus();
        //    syllabus.Name = bootcampGroup.Name;
        //    bootcampGroup.Syllabus = syllabus;

        //    // check existing name:
        //    BootcampGroup bootcampGroupRepo = await _repoBootcampGroup.GetByNameAsync(bootcampGroup.Name);
        //    if (bootcampGroupRepo is not null)
        //    {
        //        throw new Exception(ResponseCode.bootcampGroupAlreadyExist);
        //    }

        //    // add to bootcamp_group:
        //    await _repoBootcampGroup.AddAsync(bootcampGroup);
        //}

        //public async Task DeleteAsync(int bootcampGroupId)
        //{
        //    // check existing data:
        //    BootcampGroup bootcampGroupExisting = await _repoBootcampGroup.GetByIdAsync(bootcampGroupId);
        //    if (bootcampGroupExisting is null)
        //    {
        //        throw new Exception(ResponseCode.bootcampGroupNotFound);
        //    }

        //    // delete from database:
        //    await _repoBootcampGroup.DeleteAsync(bootcampGroupExisting);
        //}

        public async Task<IEnumerable<BootcampGroupVM>> GetAsync()
        {
            // get list data from repository:
            IEnumerable<BootcampGroup> listBootcampGroup = await _repoBootcampGroup.GetAsync();

            // convert list of model object to list of dto object, then return the result:
            return _mapper.Map<IEnumerable<BootcampGroup>, IEnumerable<BootcampGroupVM>>(listBootcampGroup);
        }

        //public async Task<List<BootcampGroupAndTotalMemberDto>> GetWithTotalMembersAsync()
        //{
        //    List<BootcampGroup> listBootcampGroup = await _repoBootcampGroup.GetAsync();
        //    List<BootcampGroupDto> listBootcampGroupDto = _mapper.Map<List<BootcampGroup>, List<BootcampGroupDto>>(listBootcampGroup);
        //    List<UserBootcamp> listUserBootcamp = await _repoUserBootcamp.GetAsync();
        //    List<BootcampGroupAndTotalMemberDto> listBootcampGroupAndTotalMember = new List<BootcampGroupAndTotalMemberDto>();

        //    if (listUserBootcamp is null)
        //    {
        //        listBootcampGroupAndTotalMember = _mapper.Map<List<BootcampGroup>, List<BootcampGroupAndTotalMemberDto>>(listBootcampGroup);
        //    }
        //    else
        //    {
        //        List<UserBootcampDto> listUserBootcampDto = _mapper.Map<List<UserBootcamp>, List<UserBootcampDto>>(listUserBootcamp);
        //        List<UserBootcamp> ListActiveMembers = await _repoUserBootcamp.GetActiveMembersAsync();

        //        IEnumerable<BootcampGroupAndTotalMemberDto> getBootcampGroupAndTotalMemberQuery =
        //            from bg in listBootcampGroupDto
        //            join ub in ListActiveMembers
        //            on bg.Id equals ub.BootcampGroupId into g
        //            select new BootcampGroupAndTotalMemberDto
        //            {
        //                Id = bg.Id,
        //                Name = bg.Name,
        //                Description = bg.Description,
        //                IsActive = bg.IsActive,
        //                CountMember = g.Count()
        //            };

        //        listBootcampGroupAndTotalMember = getBootcampGroupAndTotalMemberQuery.ToList();
        //    }

        //    return listBootcampGroupAndTotalMember;
        //}

        //public async Task<BootcampGroupDto> GetByIdAsync(int bootcampGroupId)
        //{
        //    BootcampGroup bootcampGroupExisting = await _repoBootcampGroup.GetByIdAsync(bootcampGroupId);
        //    return _mapper.Map<BootcampGroup, BootcampGroupDto>(bootcampGroupExisting);
        //}

        //public async Task UpdateAsync(BootcampGroupDto bootcampGroupDto)
        //{
        //    // convert from dto object to model object:
        //    BootcampGroup bootcampGroup = _mapper.Map<BootcampGroupDto, BootcampGroup>(bootcampGroupDto);

        //    // check existing data:
        //    BootcampGroup bootcampGroupExisting = await _repoBootcampGroup.GetByIdAsync(bootcampGroup.Id);
        //    if (bootcampGroupExisting is null)
        //    {
        //        throw new Exception(ResponseCode.bootcampGroupNotFound);
        //    }

        //    // edit syllabus data on bootcamp:
        //    bootcampGroupExisting.Syllabus.Name = bootcampGroup.Name;
        //    bootcampGroup.Syllabus = bootcampGroupExisting.Syllabus;

        //    // update model to bootcamp_group:
        //    await _repoBootcampGroup.UpdateAsync(bootcampGroup);
        //}

        //public async Task UpdateStatusAsync(int bootcampGroupId, bool isActive)
        //{
        //    // check existing data:
        //    BootcampGroup bootcampGroupExisting = await _repoBootcampGroup.GetByIdAsync(bootcampGroupId);
        //    if (bootcampGroupExisting is null)
        //    {
        //        throw new Exception(ResponseCode.bootcampGroupNotFound);
        //    }

        //    List<UserBootcamp> listUserBootcamp = await _repoUserBootcamp.GetActiveMembersByBootcampGroupIdAsync(bootcampGroupId);

        //    // check if any members in this bootcamp_group when wants to inactive a bootcamp:
        //    if (!isActive && listUserBootcamp.Count() > 0)
        //    {
        //        throw new Exception(ResponseCode.bootcampGroupCannotBeChangedToInactive);
        //    }

        //    bootcampGroupExisting.IsActive = isActive;
        //    await _repoBootcampGroup.UpdateAsync(bootcampGroupExisting);
        //}
    }
}