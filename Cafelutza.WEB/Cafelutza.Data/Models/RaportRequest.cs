using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafelutza.Data.Models
{
    public class RaportRequest
    {
        public string? Description { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string ImageURL { get; set; }
    }
}
