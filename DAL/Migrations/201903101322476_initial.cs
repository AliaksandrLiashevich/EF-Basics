using System.Data.Entity.Migrations;

namespace DAL.Migrations
{    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_items",
                c => new
                    {
                        cln_id = c.Int(nullable: false, identity: true),
                        cln_description = c.String(),
                        cln_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.cln_id);

            Sql(@"insert into tbl_items (cln_description, cln_price) values ('56 Blue Freen', 3.5)");
            Sql(@"insert into tbl_items (cln_description, cln_price) values ('Spline End (Xtra Large)', 0.25)");
            Sql(@"insert into tbl_items (cln_description, cln_price) values ('3 Red Freen', 12)");
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_items");
        }
    }
}
