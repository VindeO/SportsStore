using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Core.Domain;
using SportsStore.Mvc4.Infrastructure.AutoMapper;

namespace SportsStore.Mvc4.Models
{
    public class ProductViewModel:IMapFrom<Product>
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

    }
}