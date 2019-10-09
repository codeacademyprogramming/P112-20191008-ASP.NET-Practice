using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CruiseDemo.Models
{
    public class BlogViewModel
    {
        public List<Blog> Blogs { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}