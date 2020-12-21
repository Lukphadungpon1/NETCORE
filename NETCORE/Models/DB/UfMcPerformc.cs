using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class UfMcPerformc
    {
        public string Monum { get; set; }
        public int? Entryid { get; set; }
        public string Problem { get; set; }
        public string Action { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }
    }
}
