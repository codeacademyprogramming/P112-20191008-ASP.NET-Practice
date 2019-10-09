using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CruiseDemo.Models
{
    public class AboutViewModel
    {
        public List<AboutItem> AboutItems { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Vacancy> Vacancies { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}