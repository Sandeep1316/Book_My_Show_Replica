using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_My_Show.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        [Column(TypeName="decimal(4,2)")]
        public decimal IMDBrating { get; set; }
        public string ActorName { get; set; }
        public string ActressName { get; set; }
        public string Category { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
