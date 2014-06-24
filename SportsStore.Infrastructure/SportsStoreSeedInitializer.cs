using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Core.Domain;
using SportsStore.Infrastructure.Contexts;

namespace SportsStore.Infrastructure
{
    public class SportsStoreSeedInitializer:DropCreateDatabaseAlways<SportsStoreContext>
    {
        protected override void Seed(SportsStoreContext context)
        {
            //base.Seed(context);
            context.Products.Add(new Product
            {
                Name = "Product1",
                Description = "Product1 Description",
                Category = "Category1",
                Price = 1.0m
            });

            context.SaveChanges();
        }
    }
}
