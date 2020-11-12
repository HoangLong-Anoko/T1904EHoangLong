using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MVC_Core.Models;

namespace MVC_Core.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        //public string Invoke()
        //{
        //    return "Hello from the Nav View Component";
        //}

        private IStoreRepository repository;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Employees);
        }
    }
}
