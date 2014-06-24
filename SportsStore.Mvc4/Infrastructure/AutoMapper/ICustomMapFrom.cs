using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace SportsStore.Mvc4.Infrastructure.AutoMapper
{
    public interface ICustomMapFrom
    {
        void CreateMappings(IConfiguration configuration);
    }
}
