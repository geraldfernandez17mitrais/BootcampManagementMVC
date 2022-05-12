using BootcampManagementMVC.DA.Interfaces;

namespace BootcampManagementMVC.DA.Repositories
{
    public class UserBootcampRepository : IUserBootcampRepository
    {
        private readonly AppDbContext _context;

        public UserBootcampRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}