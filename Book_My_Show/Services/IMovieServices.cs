using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Models;

namespace Book_My_Show.Services
{
    public interface IMovieServices
    {
        public List<Movie> GetMovies();
        public Movie GetMovieById(int movieId);
        public List<Movie> GetMovieByName(string movieName);
        public List<Movie> GetMovieByCategory(string category);
        public List<Movie> GetMovieByGenre(string genre);
        public List<Movie> GetMovieByCity(string city);
    }
}
