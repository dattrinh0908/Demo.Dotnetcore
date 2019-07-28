using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Model.Models
{
    [Table("SystemConfigs")]
   public class SystemConfig
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Code { get; set; }

        [MaxLength(50)]
        public string ValueString { get; set; }

        public int? ValueInt { get; set; }
    }
}
