namespace Himac.Data.Migrations
{
    using Himac.Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Himac.Data.HimacDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Himac.Data.HimacDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
//            context.LinhVucs.AddOrUpdate(x => x.LinhVucId,
//    new LinhVuc() { TenLinhVuc = "An ninh quốc gia" },
//    new LinhVuc() { TenLinhVuc = "An ninh trật tự" },
//    new LinhVuc() { TenLinhVuc = "Báo chí-Truyền hình" },
//    new LinhVuc() { TenLinhVuc = "Bảo hiểm" },
//    new LinhVuc() { TenLinhVuc = "Cán bộ-Công chức-Viên chức" },
//    new LinhVuc() { TenLinhVuc = "Chính sách" },
//    new LinhVuc() { TenLinhVuc = "Chứng khoán" },
//    new LinhVuc() { TenLinhVuc = "Cơ cấu tổ chức" },
//    new LinhVuc() { TenLinhVuc = "Cổ phần-Cổ phần hoá" },
//    new LinhVuc() { TenLinhVuc = "Công nghiệp" },
//    new LinhVuc() { TenLinhVuc = "Cư trú-Hộ khẩu" },
//    new LinhVuc() { TenLinhVuc = "Dân sự" },
//    new LinhVuc() { TenLinhVuc = "Đất đai-Nhà ở" },
//    new LinhVuc() { TenLinhVuc = "Đấu thầu-Cạnh tranh" },
//    new LinhVuc() { TenLinhVuc = "Đầu tư" },
//    new LinhVuc() { TenLinhVuc = "Địa giới hành chính" },
//    new LinhVuc() { TenLinhVuc = "Điện lực" },
//    new LinhVuc() { TenLinhVuc = "Doanh nghiệp" },
//    new LinhVuc() { TenLinhVuc = "Giáo dục-Đào tạo-Dạy nghề" },
//    new LinhVuc() { TenLinhVuc = "Giao thông" },
//    new LinhVuc() { TenLinhVuc = "Hải quan" },
//    new LinhVuc() { TenLinhVuc = "Hàng hải" },
//    new LinhVuc() { TenLinhVuc = "Hành chính" },
//    new LinhVuc() { TenLinhVuc = "Hình sự" },
//    new LinhVuc() { TenLinhVuc = "Hóa chất" },
//    new LinhVuc() { TenLinhVuc = "Hôn nhân gia đình" },
//    new LinhVuc() { TenLinhVuc = "Kế toán-Kiểm toán" },
//    new LinhVuc() { TenLinhVuc = "Khiếu nại-Tố cáo" },
//    new LinhVuc() { TenLinhVuc = "Khoa học-Công nghệ" },
//    new LinhVuc() { TenLinhVuc = "Lao động-Tiền lương" },
//    new LinhVuc() { TenLinhVuc = "Lĩnh vực khác" },
//    new LinhVuc() { TenLinhVuc = "Ngoại giao" },
//    new LinhVuc() { TenLinhVuc = "Nông nghiệp-Lâm nghiệp" },
//    new LinhVuc() { TenLinhVuc = "Quốc phòng" },
//    new LinhVuc() { TenLinhVuc = "Sở hữu trí tuệ" },
//    new LinhVuc() { TenLinhVuc = "Tài chính-Ngân hàng" },
//    new LinhVuc() { TenLinhVuc = "Tài nguyên-Môi trường" },
//    new LinhVuc() { TenLinhVuc = "Thi đua-Khen thưởng-Kỷ luật" },
//    new LinhVuc() { TenLinhVuc = "Thông tin-Truyền thông" },
//    new LinhVuc() { TenLinhVuc = "Thực phẩm-Dược phẩm" },
//    new LinhVuc() { TenLinhVuc = "Thuế-Phí-Lệ phí" },
//    new LinhVuc() { TenLinhVuc = "Thương mại-Quảng cáo" },
//    new LinhVuc() { TenLinhVuc = "Thủy hải sản" },
//    new LinhVuc() { TenLinhVuc = "Tiết kiệm-Phòng, chống tham nhũng, lãng phí" },
//    new LinhVuc() { TenLinhVuc = "Tòa án" },
//    new LinhVuc() { TenLinhVuc = "Tư pháp-Hộ tịch" },
//    new LinhVuc() { TenLinhVuc = "Văn hóa-Thể thao-Du lịch" },
//    new LinhVuc() { TenLinhVuc = "Vi phạm hành chính" },
//    new LinhVuc() { TenLinhVuc = "Xây dựng" },
//    new LinhVuc() { TenLinhVuc = "Xuất nhập cảnh" },
//    new LinhVuc() { TenLinhVuc = "Xuất nhập khẩu" },
//    new LinhVuc() { TenLinhVuc = "Y tế-Sức khỏe" }
//);

//            context.LoaiVanBans.AddOrUpdate(x => x.LoaiVanBanId,
//                new LoaiVanBan() { TenLoaiVanBan = "Bản ghi nhớ" },
//                new LoaiVanBan() { TenLoaiVanBan = "Báo cáo" },
//                new LoaiVanBan() { TenLoaiVanBan = "Biên bản" },
//                new LoaiVanBan() { TenLoaiVanBan = "Bộ luật" },
//                new LoaiVanBan() { TenLoaiVanBan = "Chỉ thị" },
//                new LoaiVanBan() { TenLoaiVanBan = "Chỉ thị liên tịch" },
//                new LoaiVanBan() { TenLoaiVanBan = "Chương trình" },
//                new LoaiVanBan() { TenLoaiVanBan = "Công điện" },
//                new LoaiVanBan() { TenLoaiVanBan = "Công ước" },
//                new LoaiVanBan() { TenLoaiVanBan = "Công văn" },
//                new LoaiVanBan() { TenLoaiVanBan = "Điều lệ" },
//                new LoaiVanBan() { TenLoaiVanBan = "Đính chính" },
//                new LoaiVanBan() { TenLoaiVanBan = "Hiến chương" },
//                new LoaiVanBan() { TenLoaiVanBan = "Hiến pháp" },
//                new LoaiVanBan() { TenLoaiVanBan = "Hiệp định" },
//                new LoaiVanBan() { TenLoaiVanBan = "Hiệp ước" },
//                new LoaiVanBan() { TenLoaiVanBan = "Hướng dẫn" },
//                new LoaiVanBan() { TenLoaiVanBan = "Kế hoạch" },
//                new LoaiVanBan() { TenLoaiVanBan = "Kế hoạch liên tịch" },
//                new LoaiVanBan() { TenLoaiVanBan = "Lệnh" },
//                new LoaiVanBan() { TenLoaiVanBan = "Luật" },
//                new LoaiVanBan() { TenLoaiVanBan = "Nghị định" },
//                new LoaiVanBan() { TenLoaiVanBan = "Nghị định thư" },
//                new LoaiVanBan() { TenLoaiVanBan = "Nghị quyết" },
//                new LoaiVanBan() { TenLoaiVanBan = "Nghị quyết liên tịch" },
//                new LoaiVanBan() { TenLoaiVanBan = "Pháp lệnh" },
//                new LoaiVanBan() { TenLoaiVanBan = "Quy chế" },
//                new LoaiVanBan() { TenLoaiVanBan = "Quy chế phối hợp" },
//                new LoaiVanBan() { TenLoaiVanBan = "Quy chuẩn Việt Nam" },
//                new LoaiVanBan() { TenLoaiVanBan = "Quy định" },
//                new LoaiVanBan() { TenLoaiVanBan = "Quy trình" },
//                new LoaiVanBan() { TenLoaiVanBan = "Quyết định" },
//                new LoaiVanBan() { TenLoaiVanBan = "Sắc lệnh" },
//                new LoaiVanBan() { TenLoaiVanBan = "Sắc luật" },
//                new LoaiVanBan() { TenLoaiVanBan = "Sao lục" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thoả thuận" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thoả ước" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thông báo" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thông báo liên tịch" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thông cáo" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thông tri" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thông tư" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thông tư liên tịch" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thư trao đổi" },
//                new LoaiVanBan() { TenLoaiVanBan = "Thủ tục hành chính" },
//                new LoaiVanBan() { TenLoaiVanBan = "Tiêu chuẩn ngành" },
//                new LoaiVanBan() { TenLoaiVanBan = "Tiêu chuẩn Việt Nam" },
//                new LoaiVanBan() { TenLoaiVanBan = "Tiêu chuẩn XDVN" },
//                new LoaiVanBan() { TenLoaiVanBan = "Tờ trình" },
//                new LoaiVanBan() { TenLoaiVanBan = "Tuyên bố chung" },
//                new LoaiVanBan() { TenLoaiVanBan = "Văn bản hợp nhất" },
//                new LoaiVanBan() { TenLoaiVanBan = "VB không có nội dung download" },
//                new LoaiVanBan() { TenLoaiVanBan = "Ý định thư" }
           // );
        }
    }
}
