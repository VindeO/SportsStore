using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Infrastructure.IServices;

namespace SportsStore.Infrastructure.Services
{
    public class LoggerService:ILoggerService
    {
        public void Log(int userId, string actionName, string controllerName, string description)
        {
            throw new NotImplementedException();
        }

        public string Test
        {
            get { return "Test"; }
        }
    }
}
