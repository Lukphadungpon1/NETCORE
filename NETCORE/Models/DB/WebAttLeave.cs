using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebAttLeave
    {
        public int RowId { get; set; }
        public int EmpCode { get; set; }
        public string Leave { get; set; }
        public string Remark { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Atkfile { get; set; }
        public long? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string SupApproveBy { get; set; }
        public DateTime? SupApproveDate { get; set; }
        public string MngApproveBy { get; set; }
        public DateTime? MngApproveDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public string CancelComment { get; set; }
        public int? Qty { get; set; }
        public decimal? Time { get; set; }
        public string Typeleave { get; set; }

        public virtual WebEmployeeList EmpCodeNavigation { get; set; }
    }
}
