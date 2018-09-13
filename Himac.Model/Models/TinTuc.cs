using Himac.Common;
using Himac.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Himac.Model.Models
{
    [Table("DM_TINTUC")]
    public class TinTuc : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TinTucId { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập thông tin vào trường này")]
        [StringLength(ConfigConst.Length.TitleMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Tiêu đề")]
        [Index(IsUnique = true)]
        public string TieuDe { set; get; }

        [StringLength(ConfigConst.Length.ContentMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Nội dung")]
        public string Content { set; get; }

        [StringLength(ConfigConst.Length.ImagePathMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Đường dẫn ảnh")]
        public string ImagePath { set; get; }

        [Required]
        public int LoaiTinTucId { set; get; }

        [ForeignKey("LoaiTinTucId")]
        public virtual LoaiTinTuc LoaiTinTuc { set; get; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}