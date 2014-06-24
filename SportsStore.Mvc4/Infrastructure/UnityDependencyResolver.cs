using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;
using Microsoft.Practices.Unity;

namespace SportsStore.Mvc4.Infrastructure
{
    public class UnityDependencyResolver:IDependencyResolver
    {
        private readonly IUnityContainer _container;
        public UnityDependencyResolver(IUnityContainer container
)
        {
            _container = container;
        }
        public object GetService(Type serviceType)
        {
            return _container.IsRegistered(serviceType) ? _container.Resolve(serviceType) : null;
            if (serviceType == typeof (IControllerFactory) || serviceType == typeof (IControllerActivator)|| serviceType == typeof(ITempDataProvider)
                || serviceType == typeof(IAsyncActionInvoker))
            {
                return null;
            }
            if (serviceType == null)
            {
                return null;
            }
            return serviceType.IsAbstract || serviceType.IsInterface
                ? _container.Resolve(serviceType)
                : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.ResolveAll(serviceType);
        }

     
    }
}