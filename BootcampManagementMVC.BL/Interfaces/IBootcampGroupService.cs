using BootcampManagementMVC.BL.ViewModels.BootcampGroups;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.BL.Interfaces
{
    public interface IBootcampGroupService
    {
        Task<IEnumerable<BootcampGroupVM>> GetAsync();
        //Task<BootcampGroupDto> GetByIdAsync(int bootcampGroupId);
        //Task AddAsync(BootcampGroupPostDto bootcampGroupPostDto);
        //Task UpdateAsync(BootcampGroupDto bootcampGroupDto);
        //Task DeleteAsync(int bootcampGroupId);
        //Task<List<BootcampGroupAndTotalMemberDto>> GetWithTotalMembersAsync();
        //Task UpdateStatusAsync(int bootcampGroupId, bool isActive);
    }
}