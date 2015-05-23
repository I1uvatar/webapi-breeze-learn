using System.Data.Entity.ModelConfiguration;
using BookDemoAPI.Entities;

namespace BookDemoAPI.DAL.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
        }
    }
}
