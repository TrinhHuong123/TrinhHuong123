namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CONGTAC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CONGTACs",
                c => new
                    {
                        CongViec = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNV = c.String(unicode: false),
                        ChucVu = c.String(unicode: false),
                        PhongBan = c.String(unicode: false),
                        NoiLamViec = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CongViec);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CONGTACs");
        }
    }
}
