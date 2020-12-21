using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebComputeraccess
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public int? Qty { get; set; }
        public int? Waranty { get; set; }
        public DateTime? Usage { get; set; }
        public string Warantystatus { get; set; }
        public string Remark { get; set; }
        public long? Status { get; set; }
        public string Fixasset { get; set; }
        public string PrNumber { get; set; }
        public string Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public string Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
