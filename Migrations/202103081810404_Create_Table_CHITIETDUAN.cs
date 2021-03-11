namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CHITIETDUAN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHITIETDUANs",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaDuAn = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CHITIETDUANs");
        }
    }
}
