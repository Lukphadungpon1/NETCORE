using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebComputeraccessHandelUse
    {
        public int Id { get; set; }
        public int? Header { get; set; }
        public string Name { get; set; }
        public int? IdEmp { get; set; }
        public int? IdComaccess { get; set; }
        public int? Qty { get; set; }
        public DateTime? Dates { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Status { get; set; }
    }
}
