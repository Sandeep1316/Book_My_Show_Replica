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
    public class TheatreController : ControllerBase
    {
        private readonly ITheatreServices theatreServices;
        public TheatreController(ITheatreServices _theatreServices)
        {
            this.theatreServices = _theatreServices;
        }
        [HttpGet("theatres/id={id:int}")]
        public Theatre GetTheatre(int id)
        {
            var theatre = this.theatreServices.GetTheatreById(id);
            return theatre;
        }
        [HttpGet("theatres/city")]
        public List<Theatre> GetTheatresByCity(string city)
        {
            var theatres = this.theatreServices.GetTheatreByCity(city);
            return theatres;
        }
        [HttpGet("theatres/id={id:int}/city={city}")]
        public List<Theatre> GetTheatresByMovieInCity(int id, string city)
        {
            var theatres = this.theatreServices.GetTheatreByMovieInCity(id, city);
            return theatres;
        }
    }
}
