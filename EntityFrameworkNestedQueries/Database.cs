using System.Data.Entity;

namespace EntityFrameworkNestedQueries
{
    class Database : DbContext
    {
        public Database() : base("Default")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
