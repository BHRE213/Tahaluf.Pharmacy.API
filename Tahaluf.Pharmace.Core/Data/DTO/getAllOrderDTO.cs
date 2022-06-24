using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Pharmace.Core.Data.DTO
{
    public  class getAllOrderDTO
    {
        public int id{ get; set; }
        public string username { get; set; }
        public string medicine { get; set; }
        public double? price { get; set; }
        public string states { get; set; }
        public double? totalprice { get; set; }
        public int? quantity { get; set; }
        public DateTime? Orderdate { get; set; }
    }
}
