using Himac.Common;
using Himac.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Himac.Model.Models
{
    [Table("DM_LOAI_HOIDAP")]
    public class LoaiHoiDap : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoaiHoiDapId { set; get; }

        [Required]
        [MaxLength(ConfigConst.Length.NameMaxLength)]
        [Display(Name = "Chủ đề")]
        public string TenLoaiHoiDap { set; get; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        [Display(Name = "Mô tả")]
        public string Description { set; get; }

        [Display(Name = "Thứ tự sắp xếp")]
        public int? OrderHint { set; get; }

        public virtual IEnumerable<HoiDap> HoiDaps { set; get; }
    }
}