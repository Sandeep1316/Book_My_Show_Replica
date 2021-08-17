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
    public class TicketController : ControllerBase
    {
        private readonly ITicketServices ticketServices;
        public TicketController(ITicketServices _ticketServices)
        {
            ticketServices = _ticketServices;
        }
        [HttpGet("tickets/id1={movieId:int}/id2={theatreId:int}")]
        public Ticket GetTickets(int movieId,int theatreId)
        {
            var ticket = ticketServices.GetTicket(theatreId, movieId);
            return ticket;
        }
    }
}
