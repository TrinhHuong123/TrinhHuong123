namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CHUCVU : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHUCVUs",
                c => new
                    {
                        TenCV = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaCV = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenCV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CHUCVUs");
        }
    }
}
