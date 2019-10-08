using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CruiseDemo.Models;

namespace CruiseDemo.Models
{
    public class HomeViewModel
    {
        public List<Feature> Features { get; set; }
        public List<Advantage> Advantages { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}