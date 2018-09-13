namespace Himac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3d : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DM_HOIDAP",
                c => new
                    {
                        HoiDapId = c.Int(nullable: false, identity: true),
                        CauHoi = c.String(nullable: false, maxLength: 1000),
                        Content = c.String(),
                        ImagePath = c.String(maxLength: 500),
                        FilePath = c.String(maxLength: 500),
                        LinhVucId = c.Int(nullable: false),
                        OrderHint = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        MetaKeyword = c.String(maxLength: 128),
                        MetaDescription = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.HoiDapId)
                .ForeignKey("dbo.DM_LINHVUC", t => t.LinhVucId, cascadeDelete: true)
                .Index(t => t.CauHoi, unique: true)
                .Index(t => t.LinhVucId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DM_HOIDAP", "LinhVucId", "dbo.DM_LINHVUC");
            DropIndex("dbo.DM_HOIDAP", new[] { "LinhVucId" });
            DropIndex("dbo.DM_HOIDAP", new[] { "CauHoi" });
            DropTable("dbo.DM_HOIDAP");
        }
    }
}
