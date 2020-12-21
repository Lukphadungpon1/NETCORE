using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpidailySlitDetail
    {
        public int Rowid { get; set; }
        public int? Detailid { get; set; }
        public string Monum { get; set; }
        public int? Linenum { get; set; }
        public decimal? Cutwidth { get; set; }
        public decimal? Scrap { get; set; }
        public int? Cutqty { get; set; }
        public string SlitNo { get; set; }
        public string Barcode { get; set; }
    }
}
