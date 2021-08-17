using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Models;

namespace Book_My_Show.Services
{
    public interface IUserServices
    {
        public void AddMovieToUserBag(int movieId,int theatreId, string userId,int tickets,int screenId);
        public List<UserBag> GetBags(string userId);
    }
}
