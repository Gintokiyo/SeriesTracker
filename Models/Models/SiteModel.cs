using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Models
{
    public class SiteModel
    {
        public int SiteId { get; set; }
        public string? SiteName { get; set; }
        public string? SiteUrl { get; set; }
        public string? SiteDescription { get; set; }
        public DateTime? SiteDateWhenAdded { get; set; }
    }
}
