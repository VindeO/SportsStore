using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Mvc4.Filters;

namespace SportsStore.Mvc4.Controllers
{
    public class ProductController : Controller
    {
      
        [Log("Test")]
        public ActionResult Index()
        {
            return View();
        }

    }

    public class TestClass
    {
    }
}
