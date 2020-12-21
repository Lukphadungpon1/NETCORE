using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebAttQuotaLeave
    {
        public int Rowid { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public int? Qty { get; set; }
        public long? Status { get; set; }
        public string Type { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
