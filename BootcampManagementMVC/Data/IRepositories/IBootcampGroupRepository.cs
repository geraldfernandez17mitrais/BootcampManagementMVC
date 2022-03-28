using BootcampManagementMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Data.IRepositories
{
    public interface IBootcampGroupRepository
    {
        public Task<List<BootcampGroup>> GetBootcampGroups();
        public Task<BootcampGroup> GetBootcampGroupById(int bootcamp_group_id);
        public Task<BootcampGroup> AddBootcampGroup(BootcampGroup bootcamp_group);
        public Task<BootcampGroup> UpdateBootcampGroup(BootcampGroup bootcamp_group);
        public Task<bool> UpdateBootcampGroupStatus(int bootcamp_group_id, bool is_active);
        public Task<int> DeleteBootcampGroup(int bootcamp_group_id);
        public Task<BootcampGroup> GetBootcampGroupByName(string bootcamp_group_name);
    }
}
