using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class Overtime
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public string Dates { get; set; }
        public double? Ot1 { get; set; }
        public double? Ot15 { get; set; }
        public double? Ot3 { get; set; }
        public double? Ab { get; set; }
        public double? Sl { get; set; }
        public double? Pl { get; set; }
        public double? Al { get; set; }
    }
}
