using InventoryManagmentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagmentSystem.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Check admin credentials
                if (model.Email == "admin@example.com" && model.Password == "adminpassword")
                {
                    // Admin logged in successfully
                    // Redirect to admin panel
                    return RedirectToAction("Create", "ProductAdmin", new { area = "Admin" });
                }
                else
                {
                    // Invalid login attempt
                    ModelState.AddModelError(string.Empty, "Invalid email or password.");
                    return View(model);
                }
            }

            // Model state is invalid, return to login view with errors
            return View(model);
        }
    }
}
