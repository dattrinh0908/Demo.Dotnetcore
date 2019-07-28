using Demo.Model.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Required]
        public string Alias { get; set; }

        public string Content { get; set; }
    }
}
