using BootcampManagementMVC.DA.Interfaces;
using BootcampManagementMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
    }
}