using BootcampManagementMVC.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Controllers
{
    public class BootcampGroupsController : Controller
    {
        private readonly IBootcampGroupRepository _repo;

        public BootcampGroupsController(IBootcampGroupRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var allBootcampGroups = await _repo.GetBootcampGroups();
            return View(allBootcampGroups);
        }
    }
}
