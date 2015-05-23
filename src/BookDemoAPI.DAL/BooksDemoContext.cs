using System.Data.Entity;
using BookDemoAPI.DAL.Mapping;
using BookDemoAPI.Entities;

namespace BookDemoAPI.WebAPI.Models
{
    public partial class BooksDemoContext : DbContext
    {
        static BooksDemoContext()
        {
            Database.SetInitializer<BooksDemoContext>(null);
        }

        public BooksDemoContext()
            : base("Name=BooksDemoContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());            
        }
    }
}
