using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        private ServiceCenterEntities1 db=new ServiceCenterEntities1();
        public ActionResult Index()
        {
            return View();
        }

    }
}