using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebPermisionLogin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepUser { get; set; }
        public string Permision { get; set; }
        public long? Status { get; set; }
        public int? Runno { get; set; }
        public string Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public string Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
