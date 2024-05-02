using CsvHelper;
using InventoryManagmentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;
using System.Globalization;

namespace InventoryManagmentSystem.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public IActionResult Index()
        {
            return View();
        }

        // Export data to CSV
        public IActionResult ExportToCSV()
        {
            // Sample data 
            var productList = new List<Product>
            {
                new Product { Id = 1, Name = "Chair", Price = 10.99m, Description = "Chair" },
                new Product { Id = 2, Name = "Table", Price = 19.99m, Description = "Table" }
            };

            // Export data to CSV
            using (var memoryStream = new MemoryStream())
            using (var writer = new StreamWriter(memoryStream))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(productList);
                writer.Flush();
                var csvBytes = memoryStream.ToArray();
                return File(csvBytes, "text/csv", "products.csv");
            }
        }

        // Handle file upload
        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError("File", "Please select a file.");
                return RedirectToAction("Index");
            }

            // Process the uploaded file (e.g., save it to a temporary location)
            // Example: Save the file to a temporary location
            // var filePath = Path.GetTempFileName();
            // using (var stream = new FileStream(filePath, FileMode.Create))
            // {
            //     file.CopyTo(stream);
            // }

            // Once processed, redirect to index page or perform further operations
            return RedirectToAction("Index");
        }
    }
}
