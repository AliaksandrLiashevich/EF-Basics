using System.Data.Entity.Migrations;

namespace DAL.Migrations
{    
    public partial class item_order_custom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_order_items", "cln_quantity", c => c.Int(nullable: false));
            AddColumn("dbo.tbl_order_items", "cln_total", c => c.Decimal(nullable: false, precision: 18, scale: 2));

            Sql(@"update tbl_order_items set cln_quantity = 4, cln_total = 14.00 where cln_order_id = 1 and cln_item_id = 1");
            Sql(@"update tbl_order_items set cln_quantity = 5, cln_total = 60.00 where cln_order_id = 1 and cln_item_id = 2");
            Sql(@"update tbl_order_items set cln_quantity = 32, cln_total = 8.00 where cln_order_id = 1 and cln_item_id = 3");
            Sql(@"update tbl_order_items set cln_quantity = 500, cln_total = 1750.00 where cln_order_id = 2 and cln_item_id = 1");
            Sql(@"update tbl_order_items set cln_quantity = 750, cln_total = 9000.00 where cln_order_id = 2 and cln_item_id = 2");
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_order_items", "cln_total");
            DropColumn("dbo.tbl_order_items", "cln_quantity");
        }
    }
}
