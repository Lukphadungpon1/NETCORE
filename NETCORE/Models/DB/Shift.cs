using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class Shift
    {
        public string Shiftid { get; set; }
        public string Shiftname { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
    }
}
