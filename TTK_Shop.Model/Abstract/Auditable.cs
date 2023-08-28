using System;
using System.ComponentModel.DataAnnotations;

namespace TTK_Shop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public DateTime? CreateDate { get ; set ; }

        [MaxLength(250)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(250)]
        public string UpdateBy { get; set; }

        [MaxLength(250)]
        public string MetaKeyword { get; set; }

        [MaxLength(250)]
        public string MetaDscription { get; set; }

        public bool Status { get; set; }
    }
}