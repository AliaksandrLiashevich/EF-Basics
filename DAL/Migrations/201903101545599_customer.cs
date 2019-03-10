using System.Data.Entity.Migrations;

namespace DAL.Migrations
{    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_customer",
                c => new
                    {
                        cln_id = c.Int(nullable: false, identity: true),
                        cln_firstname = c.String(),
                        cln_lastname = c.String(),
                        cln_patronym = c.String(),
                        cln_address = c.String(),
                        cln_city = c.String(),
                        cln_state = c.String(),
                    })
                .PrimaryKey(t => t.cln_id);
            
            AddColumn("dbo.tbl_orders", "cln_customer_id", c => c.Int(nullable: false));
            CreateIndex("dbo.tbl_orders", "cln_customer_id");

            Sql(@"update tbl_orders set cln_customer_id = 1 where cln_id = 1");
            Sql(@"update tbl_orders set cln_customer_id = 2 where cln_id = 2");

            Sql(@"insert into tbl_customer (cln_firstname, cln_lastname, cln_patronym, cln_address, cln_city, cln_state)
                                    values ('Inc', 'Foo', null, '23 Main St.', 'Thorpleburg', 'TX')");
            Sql(@"insert into tbl_customer (cln_firstname, cln_lastname, cln_patronym, cln_address, cln_city, cln_state)
                                    values ('R', 'Freens', 'Us', '1600 Pennsylvania Avenue', 'Washington', 'DC')");

            AddForeignKey("dbo.tbl_orders", "cln_customer_id", "dbo.tbl_customer", "cln_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_orders", "cln_customer_id", "dbo.tbl_customer");
            DropIndex("dbo.tbl_orders", new[] { "cln_customer_id" });
            DropColumn("dbo.tbl_orders", "cln_customer_id");
            DropTable("dbo.tbl_customer");
        }
    }
}
