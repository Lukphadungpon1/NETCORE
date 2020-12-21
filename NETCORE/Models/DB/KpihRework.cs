using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpihRework
    {
        public string ReworkNo { get; set; }
        public DateTime? ReworkDate { get; set; }
        public string ReworkArea { get; set; }
        public string LotNo { get; set; }
        public string ItemNo { get; set; }
        public string ItemDesc { get; set; }
        public decimal? InputQty { get; set; }
        public decimal? OutputQty { get; set; }
        public string ReworkType { get; set; }
        public decimal? Scrap { get; set; }
        public long? ReworkStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
