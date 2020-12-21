using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebNews
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime? Dates { get; set; }
        public string Pic { get; set; }
        public long? Status { get; set; }
        public string Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public string Department { get; set; }
    }
}
