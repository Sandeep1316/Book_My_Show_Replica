using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Models;
using PetaPoco;

namespace Book_My_Show.Services
{
    public class TheatreServices:ITheatreServices
    {
        private readonly Database context;
        public TheatreServices(Database database)
        {
            context = database;
        }
        public Theatre GetTheatreById(int theatreId)
        {
            Theatre theatre = context.SingleOrDefault<Theatre>("Select * from dbo.Theatres where TheatreId=@0", theatreId);
            return theatre;
        }
        public List<Theatre> GetTheatreByCity(string city)
        {
            List<Theatre> theatres = context.Fetch<Theatre>("Select * from dbo.Theatres where City=@0", city);
            return theatres;
        }
        public List<Theatre> GetTheatreByMovieInCity(int movieId, string city)
        {
            List<Theatre> theatres = context.Fetch<Theatre>("select * from dbo.Theatres inner join dbo.Tickets on dbo.Tickets.TheatreId=dbo.Theatres.TheatreId where dbo.Tickets.MovieId=@0 and City=@1", movieId, city);
            return theatres;
        }
    }
}
