using System.Collections.Generic;
using Himac.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Himac.Model.Models
{
    [Table("DM_LOAI_TINTUC")]
    public class LoaiTinTuc
    {
        public class ConstMaLoaiTinTuc
        {
            public const string Tinnoibo = "TINNOIBO";
            public const string Tinphapluat = "TINPHAPLUAT";
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoaiTinTucId { set; get; }

        [Required]
        [MaxLength(ConfigConst.Length.MaMaxLength)]
        [Display(Name = "Mã Loại Tin tức")]
        public string MaLoaiTinTuc { set; get; }

        [Required]
        [MaxLength(ConfigConst.Length.NameMaxLength)]
        [Display(Name = "Loại Tin tức")]
        public string TenLoaiTinTuc { set; get; }

        public virtual IEnumerable<TinTuc> TinTucs { set; get; }
    }
}