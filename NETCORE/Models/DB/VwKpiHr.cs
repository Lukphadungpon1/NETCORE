using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class VwKpiHr
    {
        public string Monum { get; set; }
        public string Timetype { get; set; }
        public decimal? Wdhrs { get; set; }
        public decimal? Mchrs { get; set; }
        public decimal? RecycStock { get; set; }
        public decimal? Hrs { get; set; }
    }
}
