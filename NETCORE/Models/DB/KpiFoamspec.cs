using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpiFoamspec
    {
        public string Monum { get; set; }
        public decimal? Hphtemp { get; set; }
        public decimal? Hphfan { get; set; }
        public decimal? Inspeed { get; set; }
        public decimal? Outspeed { get; set; }
        public decimal? Setuplen { get; set; }
        public decimal? Setupwid { get; set; }
        public decimal? Ratio { get; set; }
    }
}
