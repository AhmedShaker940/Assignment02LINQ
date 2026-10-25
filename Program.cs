using LINQ.DataSources;
using LINQ.Models;
using System.Diagnostics.Metrics;

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
            #region Question06
            //Group all products by Category and print each group with its product count.
            //var groups = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var g in groups)
            //    Console.WriteLine($"{g.Key}: {g.Count()} products");

            #endregion
            #region Question07
            //Group products by Category and project only product names per group
            //var namesPerCategory = Source.ProductList
            //                             .GroupBy(p => p.Category)
            //                             .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });
            //foreach (var g in namesPerCategory)
            //{
            //    Console.WriteLine(g.Category);
            //    foreach (var n in g.Names)
            //        Console.WriteLine($"   {n}");
            //}
            #endregion
            #region Question08
            //Find all categories that have MORE THAN 3 products
            //var bigCategories = Source.ProductList
            //                          .GroupBy(p => p.Category)
            //                          .Where(g => g.Count() > 3)
            //                          .Select(g => g.Key);
            //foreach (var c in bigCategories)
            //    Console.WriteLine(c);

            #endregion
            #region Question09
            //Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var byCountry = from c in Source.CustomerList
            //                group c by c.Country into g
            //                select new
            //                {
            //                    Country = g.Key,
            //                    Count = g.Count(),
            //                    TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //                };
            //foreach (var x in byCountry)
            //    Console.WriteLine($"{x.Country} | Count={x.Count} | TotalOrderValue={x.TotalOrderValue}");
            #endregion
            #region Question10
            //Calculate the total number of units in stock across all products
            //Console.WriteLine(Source.ProductList.Sum(p => p.UnitsInStock));

            #endregion
            #region Question11
            //Find the CHEAPEST and MOST EXPENSIVE product prices
            //Console.WriteLine($"Cheapest: {Source.ProductList.Min(p => p.UnitPrice)}");
            //Console.WriteLine($"Most expensive: {Source.ProductList.Max(p => p.UnitPrice)}");

            #endregion

        }
    }
}
