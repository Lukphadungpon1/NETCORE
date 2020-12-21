using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebAttUpdateLeaveToBplusLog
    {
        public int RowId { get; set; }
        public string EmpCode { get; set; }
        public DateTime? Dates { get; set; }
        public string LeaveOld { get; set; }
        public string LeaveNew { get; set; }
        public string Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string TimescanInOld { get; set; }
        public string TimescanInNew { get; set; }
        public string TimescanOutOld { get; set; }
        public string TimescanOutNew { get; set; }
        public string SfKeyold { get; set; }
        public string SfKeynew { get; set; }
    }
}
