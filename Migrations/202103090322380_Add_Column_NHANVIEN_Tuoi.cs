namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_NHANVIEN_Tuoi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NHANVIENs", "Tuoi", c => c.Int(nullable: false));
            DropColumn("dbo.NHANVIENs", "DanToc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NHANVIENs", "DanToc", c => c.String(unicode: false));
            DropColumn("dbo.NHANVIENs", "Tuoi");
        }
    }
}
