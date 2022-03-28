using BootcampManagementMVC.Data.IRepositories;
using BootcampManagementMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Data.Repositories
{
    public class BootcampGroupRepository : IBootcampGroupRepository
    {
        private readonly AppDbContext _context;

        public BootcampGroupRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BootcampGroup> AddBootcampGroup(BootcampGroup bootcamp_group)
        {
            try
            {
                await _context.bootcamp_groups.AddAsync(bootcamp_group);
                await _context.SaveChangesAsync();
                var bootcamp_group_new = await GetBootcampGroupById(bootcamp_group.Id);
                return bootcamp_group_new;
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> DeleteBootcampGroup(int bootcamp_group_id)
        {
            var bootcamp_group = await _context.bootcamp_groups.FindAsync(bootcamp_group_id);
            if (bootcamp_group == null)
            {
                return 0; // bootcamp_group not found
            }

            try
            {
                _context.bootcamp_groups.Remove(bootcamp_group);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return 0;
            }

            return bootcamp_group.Id;
        }

        public async Task<BootcampGroup> GetBootcampGroupById(int bootcamp_group_id) => await _context.bootcamp_groups.FindAsync(bootcamp_group_id);

        public async Task<BootcampGroup> GetBootcampGroupByName(string bootcamp_group_name) => await _context.bootcamp_groups.FirstOrDefaultAsync(bg => bg.Name.ToLower().Trim() == bootcamp_group_name.ToLower().Trim());

        public async Task<List<BootcampGroup>> GetBootcampGroups() => await _context.bootcamp_groups.ToListAsync();

        public Task<BootcampGroup> UpdateBootcampGroup(BootcampGroup bootcamp_group)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBootcampGroupStatus(int bootcamp_group_id, bool is_active)
        {
            throw new NotImplementedException();
        }
    }
}
