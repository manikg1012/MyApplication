using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApplication.Models.Bal;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class MyApplicationController : Controller
    {
        // GET: MyApplication
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyApplicationView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyApplicationView(MyApplicationBal myApplicationBal)
        { 
            //int j=0
            string result = "";
            MyApplicationDal dal = new MyApplicationDal();
             int  j =dal.myApp(myApplicationBal);
            if (j > 0)
            {
                result = "registration Success";
            }
            else {
                result = "registration Failed";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Details()
        {
           
            return View();
        
        
        }
    }
}
