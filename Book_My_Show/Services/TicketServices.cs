using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_My_Show.Models;
using PetaPoco;

namespace Book_My_Show.Services
{
    public class TicketServices:ITicketServices
    {
        private readonly Database context;
        public TicketServices(Database database)
        {
            context = database;
        }
        public Ticket GetTicket(int theatreId, int movieId)
        {
            var ticket = context.SingleOrDefault<Ticket>("Select * from dbo.Tickets where TheatreId=@0 and MovieId=@1", theatreId, movieId);
            return ticket;
        }
    }
}
