using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            this.ToTable("tbl_customer").HasKey(item => item.Id);
            this.Property(item => item.Id).HasColumnName("cln_id");
            this.Property(item => item.FirstName).HasColumnName("cln_firstname");
            this.Property(item => item.LastName).HasColumnName("cln_lastname");
            this.Property(item => item.Patronym).HasColumnName("cln_patronym");
            this.Property(item => item.Address).HasColumnName("cln_address");
            this.Property(item => item.City).HasColumnName("cln_city");
            this.Property(item => item.State).HasColumnName("cln_state");
        }
    }
}
