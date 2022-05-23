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
    }
}