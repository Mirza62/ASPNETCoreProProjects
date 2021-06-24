using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product[] productArray = {
                                        new Product {Name = "Kayak", Price = 275M},
                                        new Product {Name = "Lifejacket", Price =
                                        48.95M},
                                        new Product {Name = "Soccer ball", Price =
                                        19.50M},
                                        new Product {Name = "Corner flag", Price =
                                        34.95M}
                                     };

            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = productArray.FilterByName('s').TotalPrices();

            return View("Index", new string[] { $"PriceTotal : {priceFilterTotal:C2}", $"NameTotal: {nameFilterTotal:C2}" });

            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            //return View("Index", new string[] { $"Array Total: {arrayTotal: C2}" });

            //ShoppingCart shoppingCart = new ShoppingCart() { Products = Product.GetProducts() };

            //Product[] productArray =
            //{
            //    new Product {Name="kayak",Price= 275M},
            //    new Product {Name= "LifeJacket",Price=48.95M}
            //};

            //decimal cartTotal = shoppingCart.TotalPrices();

            //decimal arrayTotal = productArray.TotalPrices();

            //return View("Index", new string[] { $"CartTotal: {cartTotal:C2}",$"ArrayTotal : {arrayTotal:C2}" });


            //object[] data = new object[]
            //{
            //    275M,29.95M,"apple","orange", 100, 10
            //};
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal decimalvalue:
            //            total += decimalvalue;
            //            break;

            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;

            //        default:
            //            break;
            //    }
            //}
            //return View("Index", new string[] { $"Total: {total:C2}" });


            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }
            //}

            //return View("Index", new string[] { $"Total : {total:C2}"});

            //List<String> results = new List<string>();
            //foreach (var item in Product.GetProducts())
            //{
            //    string name = item?.Name ?? "<No Name>";
            //    decimal? price = item?.Price ?? 0;
            //    string realatedName = item?.Related?.Name ?? "<None>";
            //    results.Add(string.Format("Name: {0},Price:{1},Related:{2}", name, price, realatedName));

            //}
            //return View(results);
        }
    }
}
