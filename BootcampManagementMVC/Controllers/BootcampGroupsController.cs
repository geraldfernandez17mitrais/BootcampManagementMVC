using BootcampManagementMVC.BL.Interfaces;
using BootcampManagementMVC.BL.ViewModels.BootcampGroups;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampManagementMVC.Controllers
{
    public class BootcampGroupsController : Controller
    {
        private readonly IBootcampGroupService _serviceBootcampGroup;

        public BootcampGroupsController(IBootcampGroupService serviceBootcampGroup)
        {
            _serviceBootcampGroup = serviceBootcampGroup;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<BootcampGroupVM> bootcampGroups = await _serviceBootcampGroup.GetAsync();
            return View(bootcampGroups);
        }
    }
}