using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebAnnualLeaveRemain
    {
        public int RowId { get; set; }
        public int? Year { get; set; }
        public int? EmpCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Refun { get; set; }
        public DateTime? Enddate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Status { get; set; }
    }
}
