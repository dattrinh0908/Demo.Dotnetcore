using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
