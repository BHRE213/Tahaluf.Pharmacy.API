using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Testimonialstatus
    {
 
        public decimal Teststatid { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
