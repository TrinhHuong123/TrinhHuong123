namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CHUYENMON : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHUYENMONs",
                c => new
                    {
                        TenCM = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaCM = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenCM);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CHUYENMONs");
        }
    }
}
