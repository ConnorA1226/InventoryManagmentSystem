using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryDbContext _context;

        public ProductRepository(InventoryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Product> GetFilteredAndSortedProducts(string searchTerm, string sortBy)
        {
            // Start with all products
            var query = _context.Products.AsQueryable();

            // Apply filter based on search term
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Name.Contains(searchTerm));
            }

            // Apply sorting based on sortBy parameter
            switch (sortBy)
            {
                case "name":
                    query = query.OrderBy(p => p.Name);
                    break;
                case "price":
                    query = query.OrderBy(p => p.Price);
                    break;
                // Add more sorting options as needed
                default:
                    query = query.OrderBy(p => p.Id);
                    break;
            }

            // Execute the query and return the results
            return query.ToList();
        }
    }

}
