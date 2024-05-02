using System.ComponentModel.DataAnnotations;

namespace InventoryManagmentSystem.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
