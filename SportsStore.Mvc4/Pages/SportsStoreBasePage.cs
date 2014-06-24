using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SportsStore.Infrastructure.IServices;

namespace SportsStore.Mvc4.Pages
{
    public class SportsStoreBasePage:WebViewPage
    {
        [Dependency]
        public IAnalyticsService AnalyticsService { get; set; }
        public override void Execute()
        {
            //throw new NotImplementedException();
        }
    }
}