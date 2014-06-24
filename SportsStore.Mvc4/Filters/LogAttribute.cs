using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SportsStore.Infrastructure.IServices;

namespace SportsStore.Mvc4.Filters
{
    public class LogAttribute:ActionFilterAttribute
    {
        public string Description { get; set; }

        private IDictionary<string, object> _parameters; 
       [Dependency]
        public ILoggerService LoggerService { get; set; }
        public LogAttribute(string description)
        {
            Description = description;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _parameters = filterContext.ActionParameters;
            string s = LoggerService.Test;
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}