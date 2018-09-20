using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkNestedQueries
{
    [Table("Product", Schema = "Production")]
    class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public virtual List<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual List<TransactionHistory> TransactionHistories { get; set; }
    }
}