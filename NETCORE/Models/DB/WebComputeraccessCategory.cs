using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebComputeraccessCategory
    {
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public string RemarkCategory { get; set; }
        public long? StatusCategory { get; set; }
        public string CreateByCategory { get; set; }
        public DateTime? CreateDateCategory { get; set; }
    }
}
