using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using SportsStore.Base.EnityFramework;
using SportsStore.Core.Domain;

namespace SportsStore.Infrastructure.Contexts
{
    public class CustomerContext:BaseContext<CustomerContext>
    {
        public IDbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            return base.ValidateEntity(entityEntry, items);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
