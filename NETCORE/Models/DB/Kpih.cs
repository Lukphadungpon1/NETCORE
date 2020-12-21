using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class Kpih
    {
        public string Monum { get; set; }
        public DateTime? ProduceDate { get; set; }
        public string ProduceType { get; set; }
        public string ReelNo { get; set; }
        public decimal? GuideSheet { get; set; }
        public decimal? TotReel { get; set; }
        public decimal? TotWeight { get; set; }
        public decimal? Scarp { get; set; }
        public decimal? Reguiding { get; set; }
        public decimal? Yield { get; set; }
        public decimal? Qcng { get; set; }
        public decimal? Qcyield { get; set; }
        public decimal? KgHr { get; set; }
        public decimal? Rpm { get; set; }
        public decimal? Resin { get; set; }
        public decimal? Screw { get; set; }
        public decimal? QtyRoll { get; set; }
        public decimal? QtyRollNg { get; set; }
        public decimal? InputLen { get; set; }
        public decimal? OutputLen { get; set; }
        public decimal? NgLen { get; set; }
        public decimal? InputWet { get; set; }
        public decimal? OutputWet { get; set; }
        public decimal? Productivity { get; set; }
        public string FullReel { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public decimal? RecycStock { get; set; }
        public decimal? ActHrs { get; set; }
        public decimal? NonHrs { get; set; }
        public decimal? Rolls { get; set; }
        public string Machine { get; set; }
        public decimal? ScrapCalculate { get; set; }
    }
}
