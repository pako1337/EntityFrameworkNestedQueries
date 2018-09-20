using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkNestedQueries
{
    [Table("ProductCostHistory", Schema = "Production")]
    public class ProductCostHistory
    {
        [Key, Column(Order = 0)]
        public int ProductID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime StartDate { get; set; }
        public decimal? StandardCost { get; set; }
    }
}