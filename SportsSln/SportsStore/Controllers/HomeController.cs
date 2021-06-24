using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository _storeRepository;
        public int pageSize = 4;

        public HomeController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public ViewResult Index(string category,int ProductPage = 1) 
            => View(new ProductsListViewModel
        {
            Products = _storeRepository.Products
            .Where(p => category == null || p.Category == category)
            .OrderBy(p => p.ProductId)
                .Skip((ProductPage - 1) * pageSize)
                .Take(pageSize),
            PagingInfo = new PagingInfo { 
                CurrentPage = ProductPage, 
                ItemsPerPage = pageSize,
                TotalItems = category == null ? 
                _storeRepository.Products.Count() : 
                _storeRepository.Products.Where(e => 
                e.Category == category).Count()
        },
                CurrentCategory = category
        });
    }
}
