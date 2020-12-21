using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebSwitchHolidayD
    {
        public int Rowid { get; set; }
        public int? Idhead { get; set; }
        public string Empcode { get; set; }
        public DateTime? Dates { get; set; }
        public decimal? Qty { get; set; }
    }
}
