using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Model.Interface
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescriptions { get; set; }

        public bool Status { get; set; }

    }
}