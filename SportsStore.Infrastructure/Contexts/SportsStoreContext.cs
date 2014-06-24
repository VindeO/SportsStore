using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Base.EnityFramework;
using SportsStore.Core.Domain;

namespace SportsStore.Infrastructure.Contexts
{
    public class SportsStoreContext:DbContext
    {
        public SportsStoreContext():base("name=SprotsStore")
        {
            Database.Initialize(true);
        }
        public IDbSet<Product> Products { get; set; }
    }
}
