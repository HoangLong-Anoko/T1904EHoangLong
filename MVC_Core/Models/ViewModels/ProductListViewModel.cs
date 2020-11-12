using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Core.Models;

namespace MVC_Core.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Employees> Employees { get; set; }
        public PageInfo PageInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
