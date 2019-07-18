using System;

namespace Demo.Model.Interface
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }

        string MetaKeyword { get; set; }

        string MetaDescriptions { get; set; }

        bool Status { get; set; }
    }
}