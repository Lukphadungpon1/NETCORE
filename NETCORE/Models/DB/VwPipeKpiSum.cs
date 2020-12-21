using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class VwPipeKpiSum
    {
        public string Monum { get; set; }
        public decimal? SlitingHrs { get; set; }
        public decimal? BondingHrs { get; set; }
        public decimal? VerticalHrs { get; set; }
        public decimal? PunchingHrs { get; set; }
        public decimal? PackingHrs { get; set; }
    }
}
