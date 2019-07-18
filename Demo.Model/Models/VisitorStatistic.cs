using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Model.Models
{

    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public int IPAddress { get; set; }
    }
}
