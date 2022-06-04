using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Orderstate
    {
     

        public decimal Orderstatesid { get; set; }
        public string Statesname { get; set; }

        public virtual ICollection<Ordder> Ordders { get; set; }
    }
}
