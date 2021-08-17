using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PetaPoco;
using System.Data.SqlClient;
using Book_My_Show.Models;

namespace Book_My_Show.Services
{
    public class UserBagServices: IUserServices
    {
        public readonly Database context;
        public UserBagServices(Database _database)
        {
            context = _database;
        }
        public void AddMovieToUserBag(int movieId,int theatreId, string userId,int tickets,int screenId)
        {
            string movieName = context.SingleOrDefault<string>("select MovieName from dbo.Movies where dbo.Movies.MovieId=@0", movieId);
            string theatreName = context.SingleOrDefault<string>("select TheatreName from dbo.Theatres where TheatreId=@0", theatreId);
            string city = context.SingleOrDefault<string>("select City from dbo.Theatres where TheatreId=@0", theatreId);
            UserBag bag = new UserBag {
            UserId=userId,
            TheatreName=theatreName,
            MovieName=movieName,
            Tickets=tickets,
            City=city,
            ScreenId=screenId
            };
            context.Insert("Dbo.UserBags", bag);
        }
        public List<UserBag> GetBags(string userId)
        {
            List<UserBag> bags= context.Fetch<UserBag>("select * from dbo.UserBags where UserId=@0", userId);
            foreach(var item in bags)
            {
                Console.WriteLine(item);
            }
            if (bags.Count == 0)
            {
                return null;
            }
            return bags;
        }
    }
}
