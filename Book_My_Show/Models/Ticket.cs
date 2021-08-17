using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_My_Show.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int TheatreId { get; set; }
        public int ScreenId { get; set; }
        public int MovieId { get; set; }
    }
}
