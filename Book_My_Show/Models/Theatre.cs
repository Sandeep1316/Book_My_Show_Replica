using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_My_Show.Models
{
    public class Theatre
    {
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }
        public string City { get; set; }
        public int NumberOfHalls { get; set; }
    }
}
