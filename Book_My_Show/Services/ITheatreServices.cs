using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Models;

namespace Book_My_Show.Services
{
    public interface ITheatreServices
    {
        public Theatre GetTheatreById(int theatreId);
        public List<Theatre> GetTheatreByCity(string city);
        public List<Theatre> GetTheatreByMovieInCity(int movieId, string city);
    }
}
