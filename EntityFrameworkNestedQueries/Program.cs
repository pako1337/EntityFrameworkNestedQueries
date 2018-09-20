using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkNestedQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var productIds = new List<int> { 707, 708, 709, 711 };

            using (var db = new Database())
            {
                var products = db.Products.Where(p => productIds.Contains(p.ProductID))
                    .Select(p => new
                    {
                        Entity = p,
                        Extras = new
                        {
                            TotalTransactions = p.TransactionHistories.Count(),
                            TotalCostChanges = p.ProductCostHistories.Count(),
                            AverageTransactionCost = p.TransactionHistories.Average(t => t.Quantity * t.ActualCost),
                            MaxQuantity = (int?)p.TransactionHistories.Max(t => t.Quantity)
                        }
                    });

                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Entity.ProductID}\t{product.Entity.Name}\t{product.Extras.TotalCostChanges}\t{product.Extras.TotalTransactions}\t{product.Extras.MaxQuantity}");
                }
            }

            Console.ReadKey();
        }
    }
}
