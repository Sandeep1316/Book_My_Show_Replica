using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Services;
using Book_My_Show.Models;

namespace Book_My_Show.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices movieServices;
        public MovieController(IMovieServices _movieServices)
        {
            movieServices = _movieServices;
        }
        [HttpGet("movies")]
        public List<Movie> GetAllMovies()
        {
            return movieServices.GetMovies();
        }

        [HttpGet("movies/id={id:int}")]
        public Movie GetAMovieById(int id)
        {
            return this.movieServices.GetMovieById(id);
        }

        [HttpGet("movies/category")]
        public List<Movie> GetAllMoviesByCategory(string category)
        {
            return this.movieServices.GetMovieByCategory(category);
        }
        [HttpGet("movies/genre")]
        public List<Movie> GetAllMoviesByGenre(string category)
        {
            return this.movieServices.GetMovieByGenre(category);
        }
        [HttpGet("movies/city={city}")]
        public List<Movie> GetAllMoviesByCity(string city)
        {
            return this.movieServices.GetMovieByCity(city);
        }
    }
}
