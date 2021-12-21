namespace LTQL_1721050229.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PNN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false),
                        TenSanPham = c.String(nullable: false, maxLength: 50),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap", t => t.MaNhaCungCap, cascadeDelete: true)
                .Index(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPham", "MaNhaCungCap", "dbo.NhaCungCap");
            DropIndex("dbo.SanPham", new[] { "MaNhaCungCap" });
            DropTable("dbo.SanPham");
        }
    }
}
