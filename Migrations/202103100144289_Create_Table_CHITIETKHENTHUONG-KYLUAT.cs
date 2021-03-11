namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CHITIETKHENTHUONGKYLUAT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHITIETKHENTHUONG_KYLUATs",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 30, unicode: false),
                        SoQĐ = c.Int(nullable: false),
                        HinhThuc = c.String(unicode: false),
                        NgayHieuLuc = c.DateTime(nullable: false),
                        LyDo = c.String(unicode: false),
                        SoTien = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
            AddColumn("dbo.NHANVIENs", "CHITIETKHENTHUONG_KYLUATs_MaNV", c => c.String(maxLength: 30, unicode: false));
            CreateIndex("dbo.NHANVIENs", "CHITIETKHENTHUONG_KYLUATs_MaNV");
            AddForeignKey("dbo.NHANVIENs", "CHITIETKHENTHUONG_KYLUATs_MaNV", "dbo.CHITIETKHENTHUONG_KYLUATs", "MaNV");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NHANVIENs", "CHITIETKHENTHUONG_KYLUATs_MaNV", "dbo.CHITIETKHENTHUONG_KYLUATs");
            DropIndex("dbo.NHANVIENs", new[] { "CHITIETKHENTHUONG_KYLUATs_MaNV" });
            DropColumn("dbo.NHANVIENs", "CHITIETKHENTHUONG_KYLUATs_MaNV");
            DropTable("dbo.CHITIETKHENTHUONG_KYLUATs");
        }
    }
}
