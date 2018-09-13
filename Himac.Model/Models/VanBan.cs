using System;
using Himac.Common;
using Himac.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Himac.Model.Models
{
    [Table("DM_VANBAN")]
    public class VanBan : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VanBanId { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập thông tin vào trường này")]
        [StringLength(ConfigConst.Length.TitleMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Tên Văn bản")]
        [Index(IsUnique = true)]
        public string TenVanBan { set; get; }

        [StringLength(ConfigConst.Length.ContentMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Nội dung")]
        public string Content { set; get; }

        [StringLength(ConfigConst.Length.ImagePathMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Đường dẫn ảnh")]
        public string ImagePath { set; get; }

        [StringLength(ConfigConst.Length.FilePathnameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "File văn bản")]
        public string FilePath { set; get; }

        [StringLength(ConfigConst.Length.LongNameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Cơ quan ban hành")]
        public string CoQuanBanHanh { set; get; }

        [Display(Name = "Ngày ban hành")]
        public DateTime? NgayBanHanh { set; get; }

        [StringLength(ConfigConst.Length.LongNameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Số hiệu")]
        public string SoHieu { set; get; }

        [StringLength(ConfigConst.Length.LongNameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Áp dụng")]
        public string ApDung { set; get; }

        [Required]
        public int LinhVucId { set; get; }

        [Required]
        public int LoaiVanBanId { set; get; }

        [StringLength(ConfigConst.Length.ShortNameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Số công báo")]
        public string SoCongBao { set; get; }

        [Display(Name = "Ngày đăng công báo")]
        public DateTime? NgayDangCongBao { set; get; }

        [StringLength(ConfigConst.Length.ShortNameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Người ký")]
        public string NguoiKy { set; get; }

        [Display(Name = "Ngày hết hiệu lực")]
        public DateTime? NgayHetHieuLuc { set; get; }

        [StringLength(ConfigConst.Length.ShortNameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Tình trạng hiệu lực")]
        public string TinhTrangHieuLuc { set; get; }

        public int? OrderHint { set; get; }

        [ForeignKey("LinhVucId")]
        public virtual LinhVuc LinhVuc { set; get; }

        [ForeignKey("LoaiVanBanId")]
        public virtual LoaiVanBan LoaiVanBan { set; get; }
    }
}