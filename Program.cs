using LINQ.DataSources;
using LINQ.Models;

namespace Assignment02LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //Get top 3 most expensive products
            //var top3 = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var p in top3)
            //    Console.WriteLine(p);


            #endregion
            #region Question02

            //show page 2 of products, with page size = 5
            int pageNumber = 2, pageSize = 5;
            var page = Source.ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            foreach (var p in page)
                Console.WriteLine(p);


            #endregion


        }
    }
}
