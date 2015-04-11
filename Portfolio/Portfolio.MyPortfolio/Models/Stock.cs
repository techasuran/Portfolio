using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.MyPortfolio.Models
{
    public class Stock
    {
        public string ISINCode { get; set; }
        public string CompanyName { get; set; }
        public string Symbol { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float TotalValue { get; set; }
        //ISINCode nvarchar(25) NOT NULL  ,
//CompanyName nvarchar(100)NOT NULL,
//Symbol nvarchar(25) NOT NULL,
//Quantity INT NOT NULL,
//UnitPrice FLOAT NOT NULL,
//TotalValue AS Quantity * UnitPrice
//CONSTRAINT Stockpk_ISINCode PRIMARY KEY (ISINCode)

    }
}