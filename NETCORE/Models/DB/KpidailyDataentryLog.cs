using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpidailyDataentryLog
    {
        public int Runno { get; set; }
        public int? Entryid { get; set; }
        public string Monum { get; set; }
        public string Jobid { get; set; }
        public string Empid { get; set; }
        public string Shiftid { get; set; }
        public DateTime? Startdate { get; set; }
        public TimeSpan? Starttime { get; set; }
        public DateTime? Enddate { get; set; }
        public TimeSpan? Endtime { get; set; }
        public decimal? Min { get; set; }
        public decimal? Scrap { get; set; }
        public decimal? RecycStock { get; set; }
        public decimal? Nglen { get; set; }
        public decimal? Lenght { get; set; }
        public decimal? Weight { get; set; }
        public string Lot { get; set; }
        public string Detail { get; set; }
        public string Comment { get; set; }
        public string Reason { get; set; }
        public decimal? ReguReguidingEx { get; set; }
        public DateTime? Createdt { get; set; }
        public int? QtyLenght { get; set; }
        public string Status { get; set; }
        public string Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
