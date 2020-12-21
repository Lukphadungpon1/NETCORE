using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpiSlitMo
    {
        public int Rowid { get; set; }
        public int EntryId { get; set; }
        public string Monum { get; set; }
        public string Itemno { get; set; }
        public string Itemdesc { get; set; }
        public string Linenum { get; set; }

        public virtual KpihSlit Entry { get; set; }
    }
}
