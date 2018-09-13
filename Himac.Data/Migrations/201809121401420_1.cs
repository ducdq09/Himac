namespace Himac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DM_LINHVUC",
                c => new
                    {
                        LinhVucId = c.Int(nullable: false, identity: true),
                        TenLinhVuc = c.String(nullable: false, maxLength: 64),
                        Description = c.String(maxLength: 64),
                        OrderHint = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        MetaKeyword = c.String(maxLength: 128),
                        MetaDescription = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LinhVucId)
                .Index(t => t.TenLinhVuc, unique: true);
            
            CreateTable(
                "dbo.DM_LOAI_TINTUC",
                c => new
                    {
                        LoaiTinTucId = c.Int(nullable: false, identity: true),
                        MaLoaiTinTuc = c.String(nullable: false, maxLength: 64),
                        TenLoaiTinTuc = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.LoaiTinTucId);
            
            CreateTable(
                "dbo.DM_LOAI_VANBAN",
                c => new
                    {
                        LoaiVanBanId = c.Int(nullable: false, identity: true),
                        TenLoaiVanBan = c.String(nullable: false, maxLength: 128),
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
                .PrimaryKey(t => t.LoaiVanBanId);
            
            CreateTable(
                "dbo.DM_TINTUC",
                c => new
                    {
                        TinTucId = c.Int(nullable: false, identity: true),
                        TieuDe = c.String(nullable: false, maxLength: 1000),
                        Content = c.String(),
                        ImagePath = c.String(maxLength: 500),
                        LoaiTinTucId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        MetaKeyword = c.String(maxLength: 128),
                        MetaDescription = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TinTucId)
                .ForeignKey("dbo.DM_LOAI_TINTUC", t => t.LoaiTinTucId, cascadeDelete: true)
                .Index(t => t.TieuDe, unique: true)
                .Index(t => t.LoaiTinTucId);
            
            CreateTable(
                "dbo.DM_VANBAN",
                c => new
                    {
                        VanBanId = c.Int(nullable: false, identity: true),
                        TenVanBan = c.String(nullable: false, maxLength: 1000),
                        Content = c.String(),
                        ImagePath = c.String(maxLength: 500),
                        CoQuanBanHanh = c.String(maxLength: 256),
                        NgayBanHanh = c.DateTime(),
                        SoHieu = c.String(maxLength: 256),
                        ApDung = c.String(maxLength: 256),
                        LinhVucId = c.Int(nullable: false),
                        LoaiVanBanId = c.Int(nullable: false),
                        SoCongBao = c.String(maxLength: 64),
                        NgayDangCongBao = c.DateTime(),
                        NguoiKy = c.String(maxLength: 64),
                        NgayHetHieuLuc = c.DateTime(),
                        TinhTrangHieuLuc = c.String(maxLength: 64),
                        OrderHint = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        MetaKeyword = c.String(maxLength: 128),
                        MetaDescription = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VanBanId)
                .ForeignKey("dbo.DM_LINHVUC", t => t.LinhVucId, cascadeDelete: true)
                .ForeignKey("dbo.DM_LOAI_VANBAN", t => t.LoaiVanBanId, cascadeDelete: true)
                .Index(t => t.TenVanBan, unique: true)
                .Index(t => t.LinhVucId)
                .Index(t => t.LoaiVanBanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DM_VANBAN", "LoaiVanBanId", "dbo.DM_LOAI_VANBAN");
            DropForeignKey("dbo.DM_VANBAN", "LinhVucId", "dbo.DM_LINHVUC");
            DropForeignKey("dbo.DM_TINTUC", "LoaiTinTucId", "dbo.DM_LOAI_TINTUC");
            DropIndex("dbo.DM_VANBAN", new[] { "LoaiVanBanId" });
            DropIndex("dbo.DM_VANBAN", new[] { "LinhVucId" });
            DropIndex("dbo.DM_VANBAN", new[] { "TenVanBan" });
            DropIndex("dbo.DM_TINTUC", new[] { "LoaiTinTucId" });
            DropIndex("dbo.DM_TINTUC", new[] { "TieuDe" });
            DropIndex("dbo.DM_LINHVUC", new[] { "TenLinhVuc" });
            DropTable("dbo.DM_VANBAN");
            DropTable("dbo.DM_TINTUC");
            DropTable("dbo.DM_LOAI_VANBAN");
            DropTable("dbo.DM_LOAI_TINTUC");
            DropTable("dbo.DM_LINHVUC");
        }
    }
}
