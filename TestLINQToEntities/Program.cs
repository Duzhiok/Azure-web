using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestLINQToEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRUD operations on tables
            //TestTables();
            ViewGeneratedSQL();
            Console.WriteLine("Press any key to continue…");
            Console.ReadKey();
        }
        static void TestTables()
        {
            // the body of this method is omitted to save space
        }
        static void ViewGeneratedSQL()
        {
            using (var NWEntities =
            new NorthwindEntities())
            {
                var beverages =
                from p in NWEntities.Products
                where p.Category.CategoryName == "Beverages"
                orderby p.ProductName
                select p;
                // view SQL using ToString method
                Console.WriteLine("The SQL statement is:\n" +
                beverages.ToString());
            }
        }
    }
}