using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Portfolio.Stocks.Entities;

namespace Portfolio.Stocks.Models
{
    public class Helper
    {

        public static List<Stock> GetMyStocks()
        {
            var stockList = new List<Stock>{ new Stock{CompanyName="TataMotors",InvestedPrice=250.2532f,Quantity=100,TotalValue=0.0f},
                new Stock{CompanyName="AshokLeyland",InvestedPrice=55.5f,Quantity=40,TotalValue=0.0f},
                new Stock{CompanyName="Pipavav",InvestedPrice=74.5f,Quantity=360,TotalValue=0.0f},
                new Stock{CompanyName="Wonderla",InvestedPrice=287.7f,Quantity=20,TotalValue=0.0f},
                new Stock{CompanyName="SpiceJet",InvestedPrice=17.5f,Quantity=1020,TotalValue=0.0f}
            };

            return stockList;

        }


    }
}