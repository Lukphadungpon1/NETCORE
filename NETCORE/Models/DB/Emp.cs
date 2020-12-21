using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class Emp
    {
        public double? No { get; set; }
        public double? Depcode { get; set; }
        public double? Empcode { get; set; }
        public string NameEng { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string EMail { get; set; }
    }
}
