using BootcampManagementMVC.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Controllers
{
    public class BootcampGroupsController : Controller
    {
        private readonly IBootcampGroupRepository _repoBootcampGroup;

        public BootcampGroupsController(IBootcampGroupRepository repoBootcampGroup)
        {
            _repoBootcampGroup = repoBootcampGroup;
        }

        public async Task<IActionResult> Index()
        {
            var allBootcampGroups = await _repoBootcampGroup.GetAsync();
            return View(allBootcampGroups);
        }
    }
}