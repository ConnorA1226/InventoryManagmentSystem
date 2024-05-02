using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem.Models.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InventoryDbContext _context;

        public UnitOfWork(InventoryDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public IProductRepository Products { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
