namespace Himac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2c : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DM_HOIDAP", "LoaiHoiDapId", "dbo.DM_LOAI_HOIDAP");
            DropIndex("dbo.DM_HOIDAP", new[] { "LoaiHoiDapId" });
            AddColumn("dbo.DM_HOIDAP", "LinhVucId", c => c.Int(nullable: false));
            CreateIndex("dbo.DM_HOIDAP", "LinhVucId");
            AddForeignKey("dbo.DM_HOIDAP", "LinhVucId", "dbo.DM_LINHVUC", "LinhVucId", cascadeDelete: true);
            DropColumn("dbo.DM_HOIDAP", "LoaiHoiDapId");
            DropTable("dbo.DM_LOAI_HOIDAP");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.DM_HOIDAP", "LoaiHoiDapId", c => c.Int(nullable: false));
            DropForeignKey("dbo.DM_HOIDAP", "LinhVucId", "dbo.DM_LINHVUC");
            DropIndex("dbo.DM_HOIDAP", new[] { "LinhVucId" });
            DropColumn("dbo.DM_HOIDAP", "LinhVucId");
            CreateIndex("dbo.DM_HOIDAP", "LoaiHoiDapId");
            AddForeignKey("dbo.DM_HOIDAP", "LoaiHoiDapId", "dbo.DM_LOAI_HOIDAP", "LoaiHoiDapId", cascadeDelete: true);
        }
    }
}
