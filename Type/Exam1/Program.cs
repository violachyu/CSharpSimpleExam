using Newtonsoft.Json;
using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = "{\r\n\t\"StockQty\": 10,\r\n\t\"SafetyStockQty\": \"\",\r\n\t\"UpdatedUser\": \"David\"\r\n}";

            var stock = JsonConvert.DeserializeObject<Stock>(json);

            //// How to Fixed this exception?
            /*
             * Newtonsoft.Json.JsonSerializationException: 
             * 'Error converting value {null} to type 'System.Int32'. Path 'SafetyStockQty', line 3, position 21.'
             */
            Console.WriteLine($"The default safety stock:{stock.SafetyStockQty}");
        }
    }
}
