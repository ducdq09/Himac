namespace Himac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DM_LOAI_VANBAN",
                c => new
                    {
                        LoaiVanBanId = c.Int(nullable: false, identity: true),
                        TenLoaiVanBan = c.String(nullable: false, maxLength: 128),
                        Description = c.String(maxLength: 128),
                        Image = c.String(maxLength: 128),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        MetaKeyword = c.String(maxLength: 128),
                        MetaDescription = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LoaiVanBanId);
            
            CreateTable(
                "dbo.DM_VANBAN",
                c => new
                    {
                        VanBanId = c.Int(nullable: false, identity: true),
                        TenVanBan = c.String(nullable: false, maxLength: 128),
                        LoaiVanBanId = c.Int(nullable: false),
                        Description = c.String(maxLength: 128),
                        Content = c.String(maxLength: 128),
                        Image = c.String(maxLength: 128),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        MetaKeyword = c.String(maxLength: 128),
                        MetaDescription = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VanBanId)
                .ForeignKey("dbo.DM_LOAI_VANBAN", t => t.LoaiVanBanId, cascadeDelete: true)
                .Index(t => t.LoaiVanBanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DM_VANBAN", "LoaiVanBanId", "dbo.DM_LOAI_VANBAN");
            DropIndex("dbo.DM_VANBAN", new[] { "LoaiVanBanId" });
            DropTable("dbo.DM_VANBAN");
            DropTable("dbo.DM_LOAI_VANBAN");
        }
    }
}
