using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Base.Tasks;
using SportsStore.Infrastructure.Contexts;

namespace SportsStore.Infrastructure
{
    public class DatabaseInitializer:IRunAtInit
    {
        public void Execute()
        {
            Database.SetInitializer(new SportsStoreSeedInitializer());
        }
    }
}
