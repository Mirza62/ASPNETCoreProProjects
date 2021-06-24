using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext _context;

        public EFStoreRepository(StoreDbContext Context)
        {
            _context = Context;
        }

        public IQueryable<Product> Products => _context.Products;

        public void CreateProduct(Product p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public void SaveProduct(Product p)
        {
            _context.SaveChanges();
        }
    }
}
