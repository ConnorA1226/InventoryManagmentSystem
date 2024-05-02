using InventoryManagmentSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagmentSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductAdminController : Controller
    {
        [HttpGet]
        [Route("products")]
        public IActionResult Index()
        {
            // Action logic for displaying product list
            return View();
        }

        [HttpGet]
        [Route("products/create")]
        public IActionResult Create()
        {
            // Action logic for displaying product creation form
            return View();
        }

        [HttpPost]
        [Route("products/create")]
        public IActionResult Create(Product product)
        {
            // Action logic for handling product creation
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("products/edit/{id}")]
        public IActionResult Edit(int id)
        {
            // Action logic for displaying product edit form
            return View();
        }

        [HttpPost]
        [Route("products/edit/{id}")]
        public IActionResult Edit(int id, Product product)
        {
            // Action logic for handling product edit
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("products/delete/{id}")]
        public IActionResult Delete(int id)
        {
            // Action logic for handling product deletion
            return RedirectToAction("Index");
        }
    }
}
