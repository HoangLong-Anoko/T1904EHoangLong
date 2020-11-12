using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core.Models
{
    public interface IStoreRepository
    {
        IQueryable<Employees> Employees { get; }

    }
}
