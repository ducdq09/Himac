using Himac.Common;
using Himac.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Himac.Model.Models
{
    [Table("DM_LINHVUC")]
    public class LinhVuc : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LinhVucId { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập thông tin vào trường này")]
        [StringLength(ConfigConst.Length.MaMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Lĩnh vực")]
        [Index(IsUnique = true)]
        public string TenLinhVuc { set; get; }

        [StringLength(ConfigConst.Length.MaMaxLength, ErrorMessage = "{0} cần có độ dài từ {2} đến {1} ký tự")]
        [Display(Name = "Mô tả")]
        public string Description { set; get; }

        [Display(Name = "Thứ tự sắp xếp")]
        public int? OrderHint { set; get; }

        public virtual IEnumerable<VanBan> VanBans { set; get; }
    }
}