using BootcampManagementMVC.DA.Interfaces;
using BootcampManagementMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampManagementMVC.DA.Repositories
{
    public class BootcampGroupRepository : IBootcampGroupRepository
    {
        private readonly AppDbContext _context;

        public BootcampGroupRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(BootcampGroup bootcampGroup)
        {
            try
            {
                await _context.bootcamp_groups.AddAsync(bootcampGroup);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteAsync(BootcampGroup bootcampGroup)
        {
            try
            {
                _context.bootcamp_groups.Remove(bootcampGroup);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<BootcampGroup>> GetAsync()
        {
            try
            {
                return await _context.bootcamp_groups.Include(b => b.Syllabus).ToListAsync();
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
                return await _context.bootcamp_groups.Include(b => b.Syllabus).SingleOrDefaultAsync(b => b.Id == bootcampGroupId);
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

        public async Task UpdateAsync(BootcampGroup bootcampGroup)
        {
            BootcampGroup bootcampGroupExisting = _context.bootcamp_groups.FirstOrDefault(bg => bg.Id == bootcampGroup.Id);

            bootcampGroupExisting.Name = bootcampGroup.Name;
            bootcampGroupExisting.Description = bootcampGroup.Description;
            bootcampGroupExisting.IsActive = bootcampGroup.IsActive;

            try
            {
                _context.Entry(bootcampGroupExisting).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}