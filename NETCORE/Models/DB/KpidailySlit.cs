using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpidailySlit
    {
        public int Rowid { get; set; }
        public int EntryId { get; set; }
        public string Jobid { get; set; }
        public string Empg { get; set; }
        public string Empid { get; set; }
        public string Shiftid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Min { get; set; }
        public decimal? Length { get; set; }
        public int? Roll { get; set; }
        public int? Piece { get; set; }
        public string Detail { get; set; }
        public string Comment { get; set; }
        public DateTime? Stampdate { get; set; }

        public virtual KpihSlit Entry { get; set; }
    }
}
