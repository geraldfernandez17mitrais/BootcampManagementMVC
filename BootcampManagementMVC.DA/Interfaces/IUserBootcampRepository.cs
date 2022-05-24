using BootcampManagementMVC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.DA.Interfaces
{
    public interface IUserBootcampRepository
    {
        Task<IEnumerable<UserBootcamp>> GetAsync();
        Task<IEnumerable<UserBootcamp>> GetActiveMembersAsync();
        Task<IEnumerable<UserBootcamp>> GetActiveMembersByBootcampGroupIdAsync(int bootcampGroupId);
    }
}