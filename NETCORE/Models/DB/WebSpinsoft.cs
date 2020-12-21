using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebSpinsoft
    {
        public int Rowid { get; set; }
        public string Problem { get; set; }
        public string Process { get; set; }
        public string Learned { get; set; }
        public string Resources { get; set; }
        public string Agreement { get; set; }
        public string RequestBy { get; set; }
        public int? RequestDate { get; set; }
        public string Section { get; set; }
        public string Location { get; set; }
        public string RequestTo { get; set; }
        public string ResponBy { get; set; }
        public int? Startdate { get; set; }
        public int? Enddate { get; set; }
        public int? Status { get; set; }
        public int? Queue { get; set; }
        public string Type { get; set; }
        public string Levels { get; set; }
        public string Createby { get; set; }
        public int? Createdate { get; set; }
        public string Updateby { get; set; }
        public int? Updatedate { get; set; }
    }
}
