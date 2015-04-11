using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Stocks.Entities
{
    public class Stock
    {

        public string CompanyName { get; set; }
        public float InvestedPrice { get; set; }
        public int Quantity { get; set; }
        public float TotalValue { get; set; }


    }
}