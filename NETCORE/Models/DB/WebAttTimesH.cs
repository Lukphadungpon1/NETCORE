using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebAttTimesH
    {
        public int No { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string EmpCode { get; set; }
        public string Approve { get; set; }
        public string Approveby { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Status { get; set; }
    }
}
