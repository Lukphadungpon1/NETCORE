using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KpihSlit
    {
        public KpihSlit()
        {
            KpiSlitMos = new HashSet<KpiSlitMo>();
            KpidailySlits = new HashSet<KpidailySlit>();
        }

        public int EntryId { get; set; }
        public string SlitNo { get; set; }
        public string Areacd { get; set; }
        public string Machine { get; set; }
        public string Itemno { get; set; }
        public int? Roll { get; set; }
        public decimal? Length { get; set; }
        public int? SlitPiece { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }

        public virtual ICollection<KpiSlitMo> KpiSlitMos { get; set; }
        public virtual ICollection<KpidailySlit> KpidailySlits { get; set; }
    }
}
