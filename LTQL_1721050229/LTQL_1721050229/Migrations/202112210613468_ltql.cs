namespace LTQL_1721050229.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ltql : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        MaNhaCungCap = c.Int(nullable: false),
                        TenNhaCungCap = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCap");
        }
    }
}
