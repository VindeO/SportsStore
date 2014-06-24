using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using SportsStore.Base;
using SportsStore.Base.Tasks;
using SportsStore.Infrastructure.IServices;
using SportsStore.Infrastructure.Services;

namespace SportsStore.Infrastructure
{
    public class UnityRegistry : IConfigureUnity
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IRunAtInit, DatabaseInitializer>();
            container.RegisterType<ILoggerService,LoggerService>();
            container.RegisterType<IAnalyticsService, AnalyticsService>();
            container.RegisterType<IPerformanceService, PerformanceService>();
        }
    }
}
