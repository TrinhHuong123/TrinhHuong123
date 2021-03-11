namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TRINHDO_NGOAINGU : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TRINHDO_NGOAINGUs",
                c => new
                    {
                        TenTrinhDo = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaTrinhDo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenTrinhDo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TRINHDO_NGOAINGUs");
        }
    }
}
