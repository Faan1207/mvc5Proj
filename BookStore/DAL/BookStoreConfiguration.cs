using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace BookStore.DAL
{
    public class BookStoreConfiguration : DbConfiguration
    {
        public BookStoreConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}