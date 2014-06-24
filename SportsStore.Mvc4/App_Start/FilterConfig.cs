﻿using System.Web;
using System.Web.Mvc;
using SportsStore.Mvc4.Filters;

namespace SportsStore.Mvc4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(DependencyResolver.Current.GetService<PerformanceFilter>());
        }
    }
}