using BootcampManagementMVC.BL.Dtos.BootcampGroups;
using BootcampManagementMVC.BL.Interfaces;
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
            IEnumerable<BootcampGroupAndTotalMemberDto> bootcampGroups = await _serviceBootcampGroup.GetWithTotalMembersAsync();
            return View(bootcampGroups);
        }
    }
}