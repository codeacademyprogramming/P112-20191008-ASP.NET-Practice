using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CeyhunPortfolio.Models;

namespace CeyhunPortfolio.Models
{
    public class HomeModelView
    {
        public List<About> Abouts { get; set; }
        public List<Setting> Settings { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Start> Start { get; set; }
    }
}