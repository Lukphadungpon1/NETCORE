using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class VwKpiD
    {
        public string Monum { get; set; }
        public string Shiftid { get; set; }
        public decimal? Scrap { get; set; }
        public decimal? RecycStock { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public DateTime? Startworking { get; set; }
        public DateTime? Endworking { get; set; }
    }
}
