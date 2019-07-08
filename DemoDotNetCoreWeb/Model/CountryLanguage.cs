using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCoreWeb.Model
{
    public class CountryLanguage
    {
        public string CountryCode { get; set; }

        public string Language { get; set; }

        public char IsOfficial { get; set; }

        public float Percentage { get; set; }
    }
}
