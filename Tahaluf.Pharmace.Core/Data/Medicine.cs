using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Medicine
    {
        
        public decimal Medicineid { get; set; }
        public string Name { get; set; }
        public decimal? Medicinenumber { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public decimal? MedicineCategoryId { get; set; }
        public string Imagepath { get; set; }

        public virtual Medicinecategory MedicineCategory { get; set; }
        public virtual ICollection<Ordder> Ordders { get; set; }
    }
}
