using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebAttCategory
    {
        public int RowId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string NameTh { get; set; }
        public string Value { get; set; }
        public long? Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
