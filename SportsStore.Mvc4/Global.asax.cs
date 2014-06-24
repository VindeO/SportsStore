using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using SportsStore.Base.Tasks;
using SportsStore.Mvc4.Infrastructure;


namespace SportsStore.Mvc4
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public IUnityContainer ChildContainer
        {
            get { return (IUnityContainer)HttpContext.Current.Items["_container"]; }
            set { HttpContext.Current.Items["_container"] = value; }
        }

        private static IUnityContainer _container;

        protected void Application_Start()
        {
            Bootstrapper.Initialise();

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            
            //_container = new UnityContainer();
            //DependencyResolver.SetResolver(new UnityDependencyResolver(_container));
            //////  new StandardRegistry(_container);
            //new SportsStore.Infrastructure.UnityRegistry().Configure(_container);
            //_container.RegisterInstance<IFilterProvider>(new UnityFilterProvider(_container));

            ////FilterProviders.Providers.
            //var task = _container.Resolve<IRunAtInit>();
            //task.Execute();


        }

        public void Application_BeginRequest()
        {
           // ChildContainer = _container.CreateChildContainer();
        }

        public void Application_EndREquest()
        {
           // ChildContainer.Dispose();
           // ChildContainer = null;
        }

        public void Application_Error()
        {

        }
    }
}