using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebBorrowItequipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string RequestBy { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Statusjob { get; set; }
        public string ResponBy { get; set; }
        public string Createby { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Status { get; set; }
    }
}
