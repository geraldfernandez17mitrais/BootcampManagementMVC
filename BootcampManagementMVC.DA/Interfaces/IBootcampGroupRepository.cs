using BootcampManagementMVC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.DA.Interfaces
{
    public interface IBootcampGroupRepository
    {
        public Task<IEnumerable<BootcampGroup>> GetAsync();
    }
}