using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Useraccount
    {
      

        public decimal Useraccountid { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public decimal? Roleid { get; set; }
        public string Imagepath { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<Ordder> Ordders { get; set; }
    }
}
