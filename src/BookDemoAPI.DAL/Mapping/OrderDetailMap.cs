using System.Data.Entity.ModelConfiguration;
using BookDemoAPI.Entities;

namespace BookDemoAPI.DAL.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderDetailID);

            // Properties
            // Table & Column Mappings
            this.ToTable("OrderDetail");
            this.Property(t => t.OrderDetailID).HasColumnName("OrderDetailID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");

            // Relationships
            this.HasOptional(t => t.Book)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.BookID);
            this.HasOptional(t => t.Order)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.OrderID);

        }
    }
}
