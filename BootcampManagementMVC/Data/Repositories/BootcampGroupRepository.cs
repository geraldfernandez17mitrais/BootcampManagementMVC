using BootcampManagementMVC.Data.IRepositories;
using BootcampManagementMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<BootcampGroup> AddAsync(BootcampGroup bootcampGroup)
        {
            try
            {
                await _context.bootcamp_groups.AddAsync(bootcampGroup);
                await _context.SaveChangesAsync();
                var bootcamp_group_new = await GetByIdAsync(bootcampGroup.Id);
                return bootcamp_group_new;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int?> DeleteAsync(BootcampGroup bootcampGroup)
        {
            try
            {
                _context.bootcamp_groups.Remove(bootcampGroup);
                await _context.SaveChangesAsync();
                return bootcampGroup.Id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<BootcampGroup>> GetAsync()
        {
            try
            {
                return await _context.bootcamp_groups.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<BootcampGroup> GetByIdAsync(int bootcampGroupId)
        {
            try
            {
                return await _context.bootcamp_groups.FindAsync(bootcampGroupId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<BootcampGroup> GetByNameAsync(string bootcampGroupName)
        {
            try
            {
                return await _context.bootcamp_groups.FirstOrDefaultAsync(bg => bg.Name.ToLower().Trim() == bootcampGroupName.ToLower().Trim());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<BootcampGroup> UpdateAsync(BootcampGroup bootcampGroup)
        {
            var bootcamp_group_existing = _context.bootcamp_groups.FirstOrDefault(bg => bg.Id == bootcampGroup.Id);

            bootcamp_group_existing.Name = bootcampGroup.Name;
            bootcamp_group_existing.Description = bootcampGroup.Description;
            bootcamp_group_existing.IsActive = bootcampGroup.IsActive;

            try
            {
                _context.Entry(bootcamp_group_existing).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return bootcampGroup;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}