namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_BANGCHAMCONG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BANGCHAMCONGs",
                c => new
                    {
                        TenNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNhanVien = c.String(unicode: false),
                        Songaycong = c.Single(nullable: false),
                        Songaydilam = c.Single(nullable: false),
                        Songayvangmat = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.TenNhanVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BANGCHAMCONGs");
        }
    }
}
