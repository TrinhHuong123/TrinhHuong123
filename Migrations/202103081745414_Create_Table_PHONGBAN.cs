namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PHONGBAN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PHONGBANs",
                c => new
                    {
                        TenPB = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaPB = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenPB);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PHONGBANs");
        }
    }
}
