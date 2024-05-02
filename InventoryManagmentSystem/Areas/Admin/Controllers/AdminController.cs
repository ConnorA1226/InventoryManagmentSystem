using Microsoft.AspNetCore.Mvc;

namespace InventoryManagmentSystem.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
