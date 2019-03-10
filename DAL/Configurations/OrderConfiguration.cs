using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            this.ToTable("tbl_orders").HasKey(order => order.Id);
            this.Property(order => order.Id).HasColumnName("cln_id");
            this.Property(order => order.TotalPrice).HasColumnName("cln_total_price");

            this.HasMany<Item>(o => o.Items)
                .WithMany(i => i.Orders)
                .Map(oi =>
                        {
                            oi.MapLeftKey("cln_order_id");
                            oi.MapRightKey("cln_item_id");
                            oi.ToTable("tbl_order_items");
                        });
        }
    }
}
