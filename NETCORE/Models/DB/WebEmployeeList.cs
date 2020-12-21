using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebEmployeeList
    {
        public WebEmployeeList()
        {
            WebAttLeaves = new HashSet<WebAttLeave>();
            WebAttTimesDs = new HashSet<WebAttTimesD>();
        }

        public double? DepCode { get; set; }
        public int EmpCode { get; set; }
        public string NameTh { get; set; }
        public string LnameTh { get; set; }
        public string NameEn { get; set; }
        public string LnameEn { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public DateTime? WorkDate { get; set; }
        public double? Status { get; set; }
        public string Email { get; set; }
        public string UsernameAd { get; set; }

        public virtual ICollection<WebAttLeave> WebAttLeaves { get; set; }
        public virtual ICollection<WebAttTimesD> WebAttTimesDs { get; set; }
    }
}
