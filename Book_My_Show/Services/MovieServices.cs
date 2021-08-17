using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetaPoco;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Book_My_Show.Models;

namespace Book_My_Show.Services
{
    public class MovieServices: IMovieServices
    {
        private readonly Database context;
        public MovieServices(Database _database)
        {
            context = _database;
        }
        public List<Movie> GetMovies()
        {
            var movies = context.Fetch<Movie>("Select * from dbo.Movies");
            return movies;
        }
        public Movie GetMovieById(int movieId)
        {
            var movie = context.SingleOrDefault<Movie>("select * from dbo.Movies where MovieId = @0", movieId);
            return movie;
        }
        public List<Movie> GetMovieByName(string movieName)
        {
            var movies = context.Fetch<Movie>("Select * from dbo.Movies where MovieName REGEXP [@0]",movieName);
            return movies;
        }
        public List<Movie> GetMovieByCategory(string category)
        {
            var movies = context.Fetch<Movie>("Select * from dbo.Movies where Category=@0", category);
            return movies;
        }
        public List<Movie> GetMovieByGenre(string genre)
        {
            var movies = context.Fetch<Movie>("Select * from dbo.Movies where Genre=@0", genre);
            return movies;
        }
        public List<Movie> GetMovieByCity(string city)
        {
            var movies = context.Fetch<Movie>("select * from dbo.Movies inner join dbo.Tickets on dbo.Tickets.MovieId=dbo.Movies.MovieId inner join dbo.Theatres on dbo.Theatres.TheatreId=dbo.Tickets.TheatreId where City=@0;", city);
            return movies;
        }
    }
}
