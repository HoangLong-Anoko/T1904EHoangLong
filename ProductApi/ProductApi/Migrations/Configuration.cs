namespace ProductApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductApi.Data.ProductApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductApi.Data.ProductApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Products.AddOrUpdate(x => x.Id,
                new Models.Product() { Id = 1, Name = "A" },
                new Models.Product() { Id = 2, Name = "B" },
                new Models.Product() { Id = 3, Name = "C" });

            context.Categories.AddOrUpdate(x => x.Id,
                new Models.Category() { Id = 1, Name = "A", Genre = "A genre" },
                new Models.Category() { Id = 2, Name = "B", Genre = "B genre" },
                new Models.Category() { Id = 3, Name = "C", Genre = "C genre" });
        }
    }
}
