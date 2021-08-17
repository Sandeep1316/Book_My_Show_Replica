using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_My_Show.Models
{
    public class UserBag
    {
        public int UserBagId { get; set; }
        public string UserId { get; set; }
        public string MovieName { get; set; }
        public string TheatreName { get; set; }
        public string City { get; set; }
        public int ScreenId { get; set; }
        public int Tickets { get; set; }
    }
}
