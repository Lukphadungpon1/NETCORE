using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class Kpi
    {
        public string Kpiid { get; set; }
        public string Kpiname { get; set; }
        public decimal? Kpiweight { get; set; }
        public string Kpiunit { get; set; }
        public string Kpidetail { get; set; }
    }
}
