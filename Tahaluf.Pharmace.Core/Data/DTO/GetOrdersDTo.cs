using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Pharmace.Core.Data.DTO
{
    public class GetOrdersDTo
    {
        public decimal Orderid { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Orderdate { get; set; }
        public decimal? Orderstatesid { get; set; }
        public decimal? Useraccountid { get; set; }
        public decimal? Medicineid { get; set; }
        public string Statesname { get; set; }
        public string Name { get; set; }
        public decimal? Medicinenumber { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public decimal? MedicineCategoryId { get; set; }
        public string Imagepath { get; set; }
    }
}
