using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebTelephoneList
    {
        public int No { get; set; }
        public string Empid { get; set; }
        public string Tel { get; set; }
        public string Telin { get; set; }
        public string Gtranfer { get; set; }
        public string Area { get; set; }
        public string Section { get; set; }
        public long? Status { get; set; }
        public long? Local { get; set; }
        public long? Mobile { get; set; }
        public long? Longdisc { get; set; }
        public long? Inter { get; set; }
        public string Concurrent { get; set; }
        public string IpPhone { get; set; }
        public string Macaddress { get; set; }
        public string Ipaddress { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
