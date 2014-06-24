using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Infrastructure.IServices;

namespace SportsStore.Infrastructure.Services
{
    public class AnalyticsService:IAnalyticsService
    {
        public string Test
        {
            get { return "Test"; }
        }
    }
}
