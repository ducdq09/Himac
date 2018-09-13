using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Himac.Common;
using Himac.Model.Abstract;

namespace Himac.Model.Models
{
    [Table("DM_LOAI_VANBAN")]
    public class LoaiVanBan : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoaiVanBanId { set; get; }

        [Required]
        [MaxLength(ConfigConst.Length.NameMaxLength)]
        [Display(Name = "Loại Văn bản")]
        public string TenLoaiVanBan { set; get; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        [Display(Name = "Mô tả")]
        public string Description { set; get; }

        [Display(Name = "Thứ tự sắp xếp")]
        public int? OrderHint { set; get; }

        public virtual IEnumerable<VanBan> VanBans { set; get; }
    }
}