using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebComputeraccessDestroy
    {
        public int Id { get; set; }
        public int? Header { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public DateTime? DateDestroy { get; set; }
        public int? ComaccessId { get; set; }
        public int? Qty { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Status { get; set; }
    }
}
