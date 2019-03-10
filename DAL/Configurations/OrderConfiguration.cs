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
        }
    }
}
