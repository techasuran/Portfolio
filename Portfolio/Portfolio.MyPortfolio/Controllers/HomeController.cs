using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.MyPortfolio.Models;


namespace Portfolio.MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            var stockList =  Helper.GetPortfolio();

            return View();
        }

    }
}
