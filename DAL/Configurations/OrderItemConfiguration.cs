using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.Configurations
{
    public class OrderItemConfiguration : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemConfiguration()
        {
            this.ToTable("tbl_order_items").HasKey(orderItem => new { orderItem.OrderId, orderItem.ItemId });
            this.Property(order => order.OrderId).HasColumnName("cln_order_id");
            this.Property(order => order.ItemId).HasColumnName("cln_item_id");
            this.Property(order => order.Quantity).HasColumnName("cln_quantity");
            this.Property(order => order.Total).HasColumnName("cln_total");

            this.HasRequired<Order>(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            this.HasRequired<Item>(oi => oi.Item)
                .WithMany(i => i.OrderItems)
                .HasForeignKey(oi => oi.ItemId);
        }
    }
}
