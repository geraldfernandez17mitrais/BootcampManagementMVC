using BootcampManagementMVC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.DA.Interfaces
{
    public interface IUserBootcampRepository
    {
        public Task<IEnumerable<UserBootcamp>> GetAsync();
        public Task<IEnumerable<UserBootcamp>> GetActiveMembersAsync();
    }
}