namespace InventoryManagmentSystem.Models.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        void SaveChanges();
    }
}
