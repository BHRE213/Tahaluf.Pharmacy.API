using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Pharmace.Core.Data.DTO
{
    public class MedicneOrederDTO
    {
        public string Name { get; set; }

        public decimal? Price { get; set; }
        public string Description { get; set; }
        public decimal? Totalprice { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Orderdate { get; set; }
    }
}
