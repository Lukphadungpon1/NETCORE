using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebComputeraccessBrand
    {
        public int IdBrand { get; set; }
        public string NameBrand { get; set; }
        public long? StatusBrand { get; set; }
        public string CreateByBrand { get; set; }
        public DateTime? CreateDateBrand { get; set; }
    }
}
