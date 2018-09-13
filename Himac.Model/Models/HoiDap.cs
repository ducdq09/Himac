using System;
using Himac.Common;
using Himac.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Himac.Model.Models
{
    [Table("DM_HOIDAP")]
    public class HoiDap : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HoiDapId { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập thông tin vào trường này")]
        [StringLength(ConfigConst.Length.TitleMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Câu hỏi")]
        [Index(IsUnique = true)]
        public string CauHoi { set; get; }

        [StringLength(ConfigConst.Length.ContentMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Nội dung")]
        public string Content { set; get; }

        [StringLength(ConfigConst.Length.ImagePathMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Đường dẫn ảnh")]
        public string ImagePath { set; get; }

        [StringLength(ConfigConst.Length.FilePathnameMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "File văn bản")]
        public string FilePath { set; get; }

        [Required]
        public int LoaiHoiDapId { set; get; }

        public int? OrderHint { set; get; }

        [ForeignKey("LoaiHoiDapId")]
        public virtual LoaiHoiDap LoaiHoiDap { set; get; }
    }
}