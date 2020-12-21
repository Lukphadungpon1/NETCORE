using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpidailyRework
    {
        public int RowId { get; set; }
        public string ReworkNo { get; set; }
        public string JobId { get; set; }
        public string Empg { get; set; }
        public string EmpId { get; set; }
        public string Shift { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Min { get; set; }
        public decimal? Output { get; set; }
        public decimal? Scrap { get; set; }
        public string Detail { get; set; }
        public string Comment { get; set; }
    }
}
