using BootcampManagementMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Data.IRepositories
{
    public interface IBootcampGroupRepository
    {
        public Task<List<BootcampGroup>> GetAsync();
        public Task<BootcampGroup> GetByIdAsync(int bootcampGroupId);
        public Task<BootcampGroup> AddAsync(BootcampGroup bootcampGroup);
        public Task<BootcampGroup> UpdateAsync(BootcampGroup bootcampGroup);
        public Task<int?> DeleteAsync(BootcampGroup bootcampGroup);
        public Task<BootcampGroup> GetByNameAsync(string bootcampGroupName);
    }
}
