using System;
using System.Collections.Generic;
using System.Data.Entity.Config;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFMvcApplication8.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            DbConfiguration.SetConfiguration(new MyDbConfig());
            MBM_SOPIC_SPINE_521XEntities dbc = new MBM_SOPIC_SPINE_521XEntities();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            try
            {
                var rs = dbc.ADM_AUTHORITY_TYPE.Where(x => x.ID > 1);
                ViewBag.RS = rs;

                var postBillDetails = dbc.xpmed_PostBillDetails(-8, 1000330004, "FS");

                ViewBag.POSTBILLDETAILS = postBillDetails;

            }
            catch (Exception e)
            {
                
                throw;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
