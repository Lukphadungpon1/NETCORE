using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebPositionLevel
    {
        public double? RowId { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public double? Level { get; set; }
        public double? Status { get; set; }
        public string CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
