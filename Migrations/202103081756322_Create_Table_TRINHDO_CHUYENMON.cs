namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TRINHDO_CHUYENMON : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TRINHDO_CHUYENMONs",
                c => new
                    {
                        MaTrinhDo = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNV = c.String(unicode: false),
                        MaCM = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaTrinhDo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TRINHDO_CHUYENMONs");
        }
    }
}
