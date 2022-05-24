using AutoMapper;
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
        private readonly IMapper _mapper;

        public BootcampGroupsController(IBootcampGroupService serviceBootcampGroup, IMapper mapper)
        {
            _serviceBootcampGroup = serviceBootcampGroup;
            _mapper = mapper;
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

        // Get: BootcampGroups/Update/1
        public async Task<ActionResult> Update(int id)
        {
            BootcampGroupDto bootcampGroupDto = await _serviceBootcampGroup.GetByIdAsync(id);
            BootcampGroupPutDto bootcampGroupPutDto = _mapper.Map<BootcampGroupDto, BootcampGroupPutDto>(bootcampGroupDto);

            if (bootcampGroupPutDto == null)
                return View("NotFound");

            return View(bootcampGroupPutDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, [Bind("Id, Name, Description, IsActive")] BootcampGroupPutDto bootcampGroupPutDto)
        {
            if (!ModelState.IsValid)
            {
                return View(bootcampGroupPutDto);
            }

            try
            {
                await _serviceBootcampGroup.UpdateAsync(id, bootcampGroupPutDto);
            }
            catch (Exception ex)
            {
                ViewBag.ExceptionMessage = ex.Message;
                return View(bootcampGroupPutDto);
            }

            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Delete/1
        public async Task<ActionResult> Delete(int id)
        {
            BootcampGroupDto bootcampGroupDto = await _serviceBootcampGroup.GetByIdAsync(id);
            if (bootcampGroupDto == null)
                return View("NotFound");

            return View(bootcampGroupDto);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            BootcampGroupDto bootcampGroupDto = await _serviceBootcampGroup.GetByIdAsync(id);
            if (bootcampGroupDto == null)
                return View("NotFound");

            await _serviceBootcampGroup.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}