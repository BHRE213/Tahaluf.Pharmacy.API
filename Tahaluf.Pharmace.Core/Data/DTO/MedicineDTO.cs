using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Pharmace.Core.Data.DTO
{
    public class MedicineDTO
    {
        public decimal Medicineid { get; set; }
        public string Name { get; set; }
        public decimal? Medicinenumber { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public decimal? MedicineCategoryId { get; set; }
        public string Imagepath { get; set; }

        public string Type { get; set; }
    }
}
