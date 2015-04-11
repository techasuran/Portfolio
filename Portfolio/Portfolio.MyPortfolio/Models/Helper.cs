using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Portfolio.MyPortfolio.Models
{
    public class Helper
    {

        static string connectionString = @"data source=NEVIN\ECOM;initial catalog=FiftyTwoWeek;user id=sa;password=pwd;";
        static string sqlQuery = "select * from Stock";
        /// <summary>
        /// To do , there is a nissue with the reading and parsing of flaot, so chnaged the dataypes to int 
        /// </summary>
        /// <returns></returns>
        public static List<Stock> GetPortfolio()
        {
            var stockList = new List<Stock>();


            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                sqlConn.Open();
                var reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {



                    var stock1 = new Stock();
                    stock1.ISINCode = reader["ISINCode"].ToString();
                    stock1.CompanyName = reader["CompanyName"].ToString();
                    stock1.Symbol = reader["Symbol"].ToString();
                    stock1.Quantity = Convert.ToInt16(reader["Quantity"]);
                    stock1.UnitPrice = Convert.ToInt16(reader["UnitPrice"]);
                    stock1.TotalValue = Convert.ToInt16(reader["UnitPrice"]);


                    //var stock = new Stock
                    //{
                    //    ISINCode = reader["ISINCode"].ToString(),
                    //    CompanyName = reader["CompanyName"].ToString(),
                    //    Symbol = reader["Symbol"].ToString(),
                    //    Quantity = Convert.ToInt16(reader["Quantity"]),
                    //    UnitPrice = reader.GetFloat(4),
                    //    TotalValue =  reader.GetFloat(5),

                    //};
                    stockList.Add(stock1);

                }


                return stockList;
            }



        }


        public float GetFloat(String column, SqlDataReader reader)
        {
            float data = (reader.IsDBNull(reader.GetOrdinal(column)))
                   ? 0 : float.Parse(reader[column].ToString());
            return data;
        }
    }
}