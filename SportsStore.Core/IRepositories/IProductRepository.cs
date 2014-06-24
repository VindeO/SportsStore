using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Core.Domain;

namespace SportsStore.Core.IRepositories
{
    public interface IProductRepository:IEntityRepository<Product>
    {
    }
}
