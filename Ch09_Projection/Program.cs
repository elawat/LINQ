using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch09_Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Northwind();

            var query = db.Products
                .Where(product => product.UnitPrice < 10M)
                .OrderByDescending(product => product.UnitPrice)
                .Select(product => new { product.ProductID, product.ProductName, product.UnitPrice });
            // above we create anonymous type with only the three columns that we need

         
            foreach (var item in query)
            {
                WriteLine($"{ item.ProductID}: { item.ProductName} costs { item.UnitPrice: $#,##0.00}");
            }
        }
    }
}
