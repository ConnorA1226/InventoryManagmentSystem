using InventoryManagmentSystem.Models;
using InventoryManagmentSystem.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagmentSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(string searchTerm, string sortBy)
        {
            // Retrieve products from the repository
            var products = _unitOfWork.Products.GetFilteredAndSortedProducts(searchTerm, sortBy);

            // Pass the products to the view
            return View(products);
        }
    }
}
