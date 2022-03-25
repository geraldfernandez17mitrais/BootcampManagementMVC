using Microsoft.AspNetCore.Mvc;

namespace BootcampManagementMVC.Controllers
{
    public class BootcampGroupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
