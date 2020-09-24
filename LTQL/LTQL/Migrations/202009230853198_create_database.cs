namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKH = c.String(),
                        DiaChiKH = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128),
                        TenNCC = c.String(),
                        DiachiNCC = c.String(),
                    })
                .PrimaryKey(t => t.MaNCC);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCaps");
            DropTable("dbo.KhachHangs");
        }
    }
}
