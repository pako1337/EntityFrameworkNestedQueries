using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkNestedQueries
{
    [Table("TransactionHistory", Schema = "Production")]
    public class TransactionHistory
    {
        [Key]
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? ActualCost { get; set; }
    }
}