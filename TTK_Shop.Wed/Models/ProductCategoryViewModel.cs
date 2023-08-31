using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TTK_Shop.Model.Models;

namespace TTK_Shop.Wed.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int? ParentID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? HomeFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDscription { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}