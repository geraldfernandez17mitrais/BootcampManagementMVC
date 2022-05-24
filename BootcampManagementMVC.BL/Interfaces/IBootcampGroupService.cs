﻿using BootcampManagementMVC.BL.Dtos.BootcampGroups;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.BL.Interfaces
{
    public interface IBootcampGroupService
    {
        Task<IEnumerable<BootcampGroupDto>> GetAsync();
        Task<IEnumerable<BootcampGroupAndTotalMemberDto>> GetWithTotalMembersAsync();
        Task AddAsync(BootcampGroupPostDto bootcampGroupPostDto);
        Task<BootcampGroupDto> GetByIdAsync(int bootcampGroupId);
        Task UpdateAsync(int bootcampGroupId, BootcampGroupPutDto bootcampGroupDto);
        Task DeleteAsync(int bootcampGroupId);
    }
}