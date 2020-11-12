using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Core.Models;
using System.Reflection.Metadata.Ecma335;
using MVC_Core.Models.ViewModels;

namespace MVC_Core.Controllers
{
    public class HomeController : Controller
    {

        private IStoreRepository repository;
        public int PageSize = 4;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
           => View(new ProductListViewModel
           {
               Employees = repository.Employees
               .OrderBy(p => p.EmployeesId)
               .Skip((productPage - 1) * PageSize)
               .Take(PageSize),
               PageInfo = new PageInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   //TotalItems = repository.Products.Count()
                   TotalItems =  repository.Employees.Count()
               },
               CurrentCategory = category
           });
        //public ViewResult Index(int productPage = 1)
        //    => View(new ProductListViewModel {
        //        Products = repository.Products
        //        .OrderBy(p => p.ProductId)
        //        .Skip((productPage - 1) * PageSize)
        //        .Take(PageSize),
        //        PageInfo = new PageInfo
        //        {
        //            CurrentPage = productPage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = repository.Products.Count()
        //        }
        //    });

        //public ViewResult Index(int productPage = 1)
        //    => View(repository.Products
        //        .OrderBy(p => p.ProductId)
        //        .Skip((productPage -1) * PageSize)
        //        .Take(PageSize));

        //public IActionResult Index() => View(repository.Products);

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Index()
        //    => View();


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
