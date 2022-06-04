using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Pharmacy.API.Data
{
    public partial class Testimonial
    {
        public decimal Testimonialid { get; set; }
        public string Image { get; set; }
        public string Txt { get; set; }
        public string Title { get; set; }
        public decimal? Teststatid { get; set; }

        public virtual Testimonialstatus Teststat { get; set; }
    }
}
