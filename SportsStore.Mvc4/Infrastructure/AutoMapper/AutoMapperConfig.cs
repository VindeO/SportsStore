using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using AutoMapper;
using SportsStore.Base.Tasks;

namespace SportsStore.Mvc4.Infrastructure.AutoMapper
{
    public class AutoMapperConfig:IRunAtInit
    {
        public void Execute()
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes();
            LoadStandardMappings(types);
            LoadCustomMappings(types);
        }

        private void LoadCustomMappings(IEnumerable<Type> types)
        {
            var maps = (from t in types
                        from i in t.GetInterfaces()
                        where typeof(ICustomMapFrom).IsAssignableFrom(t) &&
                              !t.IsAbstract &&
                              !t.IsInterface
                        select (ICustomMapFrom)Activator.CreateInstance(t)).ToArray();

            foreach (var map in maps)
            {
                map.CreateMappings(Mapper.Configuration);
            }
        }

        private void LoadStandardMappings(IEnumerable<Type> types)
        {
            var maps = (from t in types
                        from i in t.GetInterfaces()
                        where i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>) &&
                              !t.IsAbstract &&
                              !t.IsInterface
                        select new
                        {
                            Source = i.GetGenericArguments()[0],
                            Destination = t
                        }).ToArray();

            foreach (var map in maps)
            {
                Mapper.CreateMap(map.Source, map.Destination);
            }
        }
    }
}