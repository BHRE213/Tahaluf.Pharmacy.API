using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Ordder
    {
        public decimal Orderid { get; set; }
        public decimal? Totalprice { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Numberofordar { get; set; }
        public DateTime? Orderdate { get; set; }
        public decimal? Orderstatesid { get; set; }
        public decimal? Useraccountid { get; set; }
        public DateTime? Ordertime { get; set; }
        public decimal? Medicineid { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual Orderstate Orderstates { get; set; }
        public virtual Useraccount Useraccount { get; set; }
    }
}
