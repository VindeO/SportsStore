using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Infrastructure.IServices
{
    public interface ILoggerService
    {
        string Test { get; }
        void Log(int userId, string actionName,string controllerName,string description);
    }
}
