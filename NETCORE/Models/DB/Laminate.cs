using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class Laminate
    {
        public string Jobid { get; set; }
        public string Jobdetail { get; set; }
        public string Jobinfo { get; set; }
        public string Kpi { get; set; }
        public string Type { get; set; }
        public string Die { get; set; }
        public string Unit { get; set; }
        public string Criteria { get; set; }
        public double? Level1 { get; set; }
        public double? Level2 { get; set; }
        public double? Level3 { get; set; }
        public string Dept { get; set; }
        public string Timetype { get; set; }
        public double? RunProduction { get; set; }
        public double? Productivity { get; set; }
        public double? Hide { get; set; }
    }
}
