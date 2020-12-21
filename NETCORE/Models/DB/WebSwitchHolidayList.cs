using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebSwitchHolidayList
    {
        public int Rowid { get; set; }
        public int? Empcode { get; set; }
        public DateTime? Dates { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }
        public decimal? Qty { get; set; }
        public string Remark { get; set; }
        public long? Status { get; set; }
        public string Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public string Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
        public string Approveby { get; set; }
        public DateTime? Approvedate { get; set; }
        public string ApproveSupby { get; set; }
        public DateTime? ApproveSupdate { get; set; }
        public string ApproveMngby { get; set; }
        public DateTime? ApproveMngdate { get; set; }
        public string Cancelby { get; set; }
        public DateTime? Canceldate { get; set; }
        public string Commentcancel { get; set; }
    }
}
