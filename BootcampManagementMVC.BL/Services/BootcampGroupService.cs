using AutoMapper;
using BootcampManagementMVC.BL.Dtos.BootcampGroups;
using BootcampManagementMVC.BL.Dtos.UserBootcamps;
using BootcampManagementMVC.BL.Helpers;
using BootcampManagementMVC.BL.Interfaces;
using BootcampManagementMVC.DA.Interfaces;
using BootcampManagementMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task AddAsync(BootcampGroupPostDto bootcampGroupPostDto)
        {
            // convert from dto object to model object:
            BootcampGroup bootcampGroup = _mapper.Map<BootcampGroupPostDto, BootcampGroup>(bootcampGroupPostDto);

            // add syllabus data to bootcamp:
            Syllabus syllabus = new Syllabus();
            syllabus.Name = bootcampGroup.Name;
            bootcampGroup.Syllabus = syllabus;

            // check existing name:
            BootcampGroup bootcampGroupRepo = await _repoBootcampGroup.GetByNameAsync(bootcampGroup.Name);
            if (bootcampGroupRepo is not null)
            {
                throw new Exception(ResponseCode.bootcampGroupAlreadyExist);
            }

            // add to bootcamp_group:
            await _repoBootcampGroup.AddAsync(bootcampGroup);
        }

        public async Task<IEnumerable<BootcampGroupDto>> GetAsync()
        {
            // get list data from repository:
            IEnumerable<BootcampGroup> listBootcampGroup = await _repoBootcampGroup.GetAsync();

            // convert list of model object to list of dto object, then return the result:
            return _mapper.Map<IEnumerable<BootcampGroup>, IEnumerable<BootcampGroupDto>>(listBootcampGroup);
        }

        public async Task<IEnumerable<BootcampGroupAndTotalMemberDto>> GetWithTotalMembersAsync()
        {
            IEnumerable<BootcampGroup> listBootcampGroup = await _repoBootcampGroup.GetAsync();
            IEnumerable<BootcampGroupDto> listBootcampGroupDto = _mapper.Map<IEnumerable<BootcampGroup>, IEnumerable<BootcampGroupDto>>(listBootcampGroup);
            IEnumerable<UserBootcamp> listUserBootcamp = await _repoUserBootcamp.GetAsync();

            if (listUserBootcamp is null)
            {
                IEnumerable<BootcampGroupAndTotalMemberDto> listBootcampGroupAndTotalMember = _mapper.Map<IEnumerable<BootcampGroup>, IEnumerable<BootcampGroupAndTotalMemberDto>>(listBootcampGroup);

                return listBootcampGroupAndTotalMember;
            }
            else
            {
                IEnumerable<UserBootcampDto> listUserBootcampDto = _mapper.Map<IEnumerable<UserBootcamp>, IEnumerable<UserBootcampDto>>(listUserBootcamp);
                IEnumerable<UserBootcamp> ListActiveMembers = await _repoUserBootcamp.GetActiveMembersAsync();

                IEnumerable<BootcampGroupAndTotalMemberDto> getBootcampGroupAndTotalMemberQuery =
                    from bg in listBootcampGroupDto
                    join ub in ListActiveMembers
                    on bg.Id equals ub.BootcampGroupId into g
                    select new BootcampGroupAndTotalMemberDto
                    {
                        Id = bg.Id,
                        SyllabusId = bg.SyllabusId,
                        Name = bg.Name,
                        Description = bg.Description,
                        IsActive = bg.IsActive,
                        CountMember = g.Count()
                    };

                IEnumerable<BootcampGroupAndTotalMemberDto> listBootcampGroupAndTotalMember = getBootcampGroupAndTotalMemberQuery.ToList();

                return listBootcampGroupAndTotalMember;
            }
        }
    }
}