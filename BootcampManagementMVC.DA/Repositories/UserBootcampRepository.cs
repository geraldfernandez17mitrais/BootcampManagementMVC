using BootcampManagementMVC.DA.Interfaces;
using BootcampManagementMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampManagementMVC.DA.Repositories
{
    public class UserBootcampRepository : IUserBootcampRepository
    {
        private readonly AppDbContext _context;

        public UserBootcampRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserBootcamp>> GetActiveMembersAsync()
        {
            try
            {
                List<UserBootcamp> listUserBootcamp = await _context.user_bootcamps.ToListAsync();
                return listUserBootcamp.Where(lub => lub.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<UserBootcamp>> GetAsync()
        {
            try
            {
                return await _context.user_bootcamps.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}