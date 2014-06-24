using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;

namespace SportsStore.Mvc4.Infrastructure
{
    public class StandardRegistry
    {
       
        public StandardRegistry(IUnityContainer container)
        {
            container.RegisterTypes(AllClasses.FromAssemblies().Where(t=>t.Namespace== "SportsStore"), 
                WithMappings.FromMatchingInterface,
                WithName.Default);
        }
    }
}