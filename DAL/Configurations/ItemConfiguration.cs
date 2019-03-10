using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.Configurations
{
    public class ItemConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemConfiguration()
        {
            this.ToTable("tbl_items").HasKey(item => item.Id);
            this.Property(item => item.Id).HasColumnName("cln_id");
            this.Property(item => item.Description).HasColumnName("cln_description");
            this.Property(item => item.Price).HasColumnName("cln_price");
        }
    }
}
