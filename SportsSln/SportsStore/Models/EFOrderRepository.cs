using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace SportsStore.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private StoreDbContext _storeDbContext;

        public EFOrderRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public IQueryable<Order> Orders => _storeDbContext.Orders.Include(o => o.Lines).ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            _storeDbContext.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderId == 0)
            {
                _storeDbContext.Orders.Add(order);
            }

            _storeDbContext.SaveChanges();
        }
    }
}
