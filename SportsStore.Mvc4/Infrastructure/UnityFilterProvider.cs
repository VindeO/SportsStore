using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace SportsStore.Mvc4.Infrastructure
{
    public class UnityFilterProvider : FilterAttributeFilterProvider
    {
        private readonly IUnityContainer _container;

        public UnityFilterProvider(IUnityContainer container)
        {
            _container = container;
        }
        public override IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            var filters = base.GetFilters(controllerContext, actionDescriptor);

            foreach (var filter in filters)
            {
                _container.BuildUp(filter.Instance.GetType(), filter.Instance);
                yield return filter;
            }
        }
    }
}