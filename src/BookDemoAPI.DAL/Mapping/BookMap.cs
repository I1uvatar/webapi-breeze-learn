using System.Data.Entity.ModelConfiguration;
using BookDemoAPI.Entities;

namespace BookDemoAPI.DAL.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            // Primary Key
            this.HasKey(t => t.BookID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            this.Property(t => t.Author)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Book");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
