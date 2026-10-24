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
            //int pageNumber = 2, pageSize = 5;
            //var page = Source.ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            //foreach (var p in page)
            //    Console.WriteLine(p);


            #endregion
            #region Question03
            //Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var cheap = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var p in cheap)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion
            #region Question04
            //Check if ALL products in the "Seafood" category are in stock

            //bool allInStock = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(allInStock);

            #endregion
            #region Question05
            //Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //Console.WriteLine(ids.Contains(9));

            #endregion


        }
    }
}
