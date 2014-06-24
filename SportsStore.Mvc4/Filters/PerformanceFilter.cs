using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SportsStore.Infrastructure.IServices;


namespace SportsStore.Mvc4.Filters
{
    public class PerformanceFilter:ActionFilterAttribute
    {
        [Dependency]
        public IPerformanceService PerformanceService { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string s = PerformanceService.Test;
            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}