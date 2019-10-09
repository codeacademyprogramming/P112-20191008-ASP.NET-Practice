using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CruiseDemo.Models
{
    public class TechnologyViewModel
    {
        public List<Feature>Features { get; set; }
        public List<Advantage> Advantages { get; set; }
        public List<Testimonial> Testimonials{ get; set; }
    }
}