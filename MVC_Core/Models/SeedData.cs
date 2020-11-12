using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MVC_Core.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employees
                    {
                        Name = "Long A",
                    },
                    new Employees
                    {
                        Name = "Long B",
                    },
                    new Employees
                    {
                        Name = "Long C",
                    },
                    new Employees
                    {
                        Name = "Long D",
                    },
                    new Employees
                    {
                        Name = "Long E",
                    },
                    new Employees
                    {
                        Name = "Long F",
                    },
                    new Employees
                    {
                        Name = "Long G",
                    },
                    new Employees
                    {
                        Name = "Long H",
                    },
                    new Employees
                    {
                        Name = "Long I",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
