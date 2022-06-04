using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Pharmacybranch
    {
        public decimal Pharmacybranchesid { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public decimal? Phone { get; set; }
        public string Y { get; set; }
        public string X { get; set; }
        public DateTime? Open { get; set; }
        public DateTime? Close { get; set; }
        public string Image { get; set; }
    }
}
