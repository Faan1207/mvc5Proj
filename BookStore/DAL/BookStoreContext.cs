using BookStore.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BookStore.DAL
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext() : base("BookStoreContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<ReservationEvents> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}