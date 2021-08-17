using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Models;

namespace Book_My_Show.Services
{
    public interface ITicketServices
    {
        public Ticket GetTicket(int TheatreId, int movieId);
    }
}
