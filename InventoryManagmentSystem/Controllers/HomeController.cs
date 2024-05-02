using Microsoft.AspNetCore.Mvc;

namespace InventoryManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult ExportToCSV()
        {
            return View();
        }
    }
}
