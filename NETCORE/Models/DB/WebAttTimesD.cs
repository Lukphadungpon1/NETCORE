using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebAttTimesD
    {
        public int No { get; set; }
        public int? IdHead { get; set; }
        public DateTime? Dates { get; set; }
        public int? Empcode { get; set; }
        public string Team { get; set; }
        public string Shift { get; set; }
        public decimal? Ot1bf { get; set; }
        public decimal? Ot15bf { get; set; }
        public decimal? Ot3bf { get; set; }
        public decimal? Ot1af { get; set; }
        public decimal? Ot15af { get; set; }
        public decimal? Ot3af { get; set; }
        public decimal? Transport { get; set; }
        public string Takeleave { get; set; }
        public string Remark { get; set; }
        public string Users { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? Status { get; set; }
        public string ApproveSup { get; set; }
        public DateTime? ApproveSupDate { get; set; }
        public string ApproveMng { get; set; }
        public DateTime? ApproveMngDate { get; set; }
        public string Cancelby { get; set; }
        public DateTime? CancelDate { get; set; }
        public string Area { get; set; }
        public string Reason { get; set; }

        public virtual WebEmployeeList EmpcodeNavigation { get; set; }
    }
}
