using BootcampManagementMVC.BL.Dtos.BootcampGroups;
using BootcampManagementMVC.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
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

        // Get: BootcampGroups/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Description, IsActive")] BootcampGroupPostDto bootcampGroupPostDto)
        {
            if (!ModelState.IsValid)
            {
                return View(bootcampGroupPostDto);
            }

            try
            {
                await _serviceBootcampGroup.AddAsync(bootcampGroupPostDto);
            }
            catch (Exception ex)
            {
                ViewBag.ExceptionMessage = ex.Message;
                return View(bootcampGroupPostDto);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}