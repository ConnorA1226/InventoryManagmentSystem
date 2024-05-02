namespace InventoryManagmentSystem.Models.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetFilteredAndSortedProducts(string searchTerm, string sortBy);
    }
}
