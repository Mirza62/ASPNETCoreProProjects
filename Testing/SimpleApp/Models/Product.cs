using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleApp.Models;

namespace SimpleApp.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal? Price { get; set; }


        public class ProductDataSource : IDataSource
        {
            public IEnumerable<Product> Products =>
                new Product[]
                {
                    new Product {Name = "kayak", Price = 275M},
                    new Product {Name = "LifeJacket", Price = 48.95M}
                };
        }

        //public static Product[] GetProducts()
        //{
        //    Product kayak = new Product
        //    {
        //        Name = "kayak",
        //        Price = 275M
        //    };

        //    Product lifeJacket = new Product
        //    {
        //        Name = "LifeJacket",
        //        Price = 48.95M
        //    };
        //    return new Product[] { kayak, lifeJacket };
        //}
    }
}
