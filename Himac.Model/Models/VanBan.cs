using Himac.Common;
using Himac.Model.Abstract;
using System.Collections.Generic;
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

        [Required]
        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string TenVanBan { set; get; }

        [Required]
        public int LoaiVanBanId { set; get; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string Description { set; get; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string Content { set; get; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string Image { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [ForeignKey("LoaiVanBanId")]
        public virtual LoaiVanBan LoaiVanBan { set; get; }
    }
}