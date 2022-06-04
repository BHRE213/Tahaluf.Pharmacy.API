using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Medicinecategory
    {
    

        public decimal Medicinecategoryid { get; set; }
        public string Type { get; set; }
        public string Imagepath { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
