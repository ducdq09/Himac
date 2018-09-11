using Himac.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Himac.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string UpdatedBy { get; set; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string MetaKeyword { get; set; }

        [MaxLength(ConfigConst.Length.NameMaxLength)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}