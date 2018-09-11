using Himac.Common;
using Himac.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string TenLoaiVanBan { set; get; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string Description { set; get; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string Image { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        public virtual IEnumerable<VanBan> VanBans { set; get; }
    }
}