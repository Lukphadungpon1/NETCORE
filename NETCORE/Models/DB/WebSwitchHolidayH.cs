using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebSwitchHolidayH
    {
        public int Rowid { get; set; }
        public string Empcode { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }
        public string Type { get; set; }
        public decimal? Qty { get; set; }
        public string Remark { get; set; }
        public long? Status { get; set; }
        public string Createby { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Updateby { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ApproveSup { get; set; }
        public DateTime? ApproveSupDate { get; set; }
        public string ApproveMng { get; set; }
        public DateTime? ApproveMngDate { get; set; }
        public string Cancelby { get; set; }
        public DateTime? CancelDate { get; set; }
        public string CancelComment { get; set; }
    }
}
