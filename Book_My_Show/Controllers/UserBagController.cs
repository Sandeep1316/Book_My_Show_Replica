using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Services;
using Book_My_Show.Models;

namespace Book_My_Show.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBagController : ControllerBase
    {
        private readonly IUserServices userServices;
        private readonly IHttpContextAccessor httpContextAccessor;
        public UserBagController(IUserServices _userServices,IHttpContextAccessor _httpContextAccessor)
        {
            userServices = _userServices;
            httpContextAccessor = _httpContextAccessor;
        }
        [HttpGet("userbags/user")]
        public List<UserBag> GetUserBags()
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var userBags = userServices.GetBags(userId);
            foreach(var item in userBags)
            {
                Console.WriteLine(item);
            }
            return userBags;
        }
        [HttpPost("addmovie/id1={movieId:int}/id2={theatreId:int}/id3={tickets:int}/id4={screenId:int}")]
        public void Post(int movieId,int theatreId,int tickets,int screenId)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            userServices.AddMovieToUserBag(movieId, theatreId, userId, tickets, screenId);
        }
    }
}
