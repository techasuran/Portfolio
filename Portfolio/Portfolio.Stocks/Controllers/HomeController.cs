﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Stocks.Models;
namespace Portfolio.Stocks.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            var stockList = Helper.GetMyStocks();


            return View(stockList);
        }

    }
}
