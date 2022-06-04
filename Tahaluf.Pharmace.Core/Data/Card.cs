using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Card
    {
        public decimal Cardid { get; set; }
        public decimal? Balance { get; set; }
        public string Cvb { get; set; }
        public string Iban { get; set; }
        public DateTime? Expiredate { get; set; }
        public decimal? Useraccountid { get; set; }

        public virtual Useraccount Useraccount { get; set; }
    }
}
