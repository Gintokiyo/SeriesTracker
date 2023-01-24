using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string? PersonName { get; set; }
        public int PersonAge { get; set; }
        public string? PersonCountryOfOrigin { get; set; }
    }
}
