using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class VwKpiSum
    {
        public string Monum { get; set; }
        public decimal? Wdhrs { get; set; }
        public decimal? Mchrs { get; set; }
        public decimal? RecycStock { get; set; }
        public decimal? Acthrs { get; set; }
    }
}
