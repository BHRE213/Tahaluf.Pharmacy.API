using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Role
    {
    

        public decimal Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Useraccount> Useraccounts { get; set; }
    }
}
