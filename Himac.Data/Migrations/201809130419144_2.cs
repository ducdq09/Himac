namespace Himac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
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
                        LoaiHoiDapId = c.Int(nullable: false),
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
                .ForeignKey("dbo.DM_LOAI_HOIDAP", t => t.LoaiHoiDapId, cascadeDelete: true)
                .Index(t => t.CauHoi, unique: true)
                .Index(t => t.LoaiHoiDapId);
            
            CreateTable(
                "dbo.DM_LOAI_HOIDAP",
                c => new
                    {
                        LoaiHoiDapId = c.Int(nullable: false, identity: true),
                        TenLoaiHoiDap = c.String(nullable: false, maxLength: 128),
                        Description = c.String(maxLength: 128),
                        OrderHint = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        MetaKeyword = c.String(maxLength: 128),
                        MetaDescription = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LoaiHoiDapId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DM_HOIDAP", "LoaiHoiDapId", "dbo.DM_LOAI_HOIDAP");
            DropIndex("dbo.DM_HOIDAP", new[] { "LoaiHoiDapId" });
            DropIndex("dbo.DM_HOIDAP", new[] { "CauHoi" });
            DropTable("dbo.DM_LOAI_HOIDAP");
            DropTable("dbo.DM_HOIDAP");
        }
    }
}
