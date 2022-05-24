using BootcampManagementMVC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.DA.Interfaces
{
    public interface IBootcampGroupRepository
    {
        Task<IEnumerable<BootcampGroup>> GetAsync();
        Task AddAsync(BootcampGroup bootcampGroup);
        Task<BootcampGroup> GetByNameAsync(string bootcampGroupName);
        Task<BootcampGroup> GetByIdAsync(int bootcampGroupId);
        Task UpdateAsync(BootcampGroup bootcampGroup);
    }
}