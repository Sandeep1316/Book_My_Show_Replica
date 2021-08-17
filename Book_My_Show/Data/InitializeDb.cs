using JsonNet.PrivateSettersContractResolvers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using Book_My_Show.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Data.SqlClient;
using PetaPoco;

namespace Book_My_Show.Data
{
	public class Seeding
	{
		public static void Seed(string moviesData,string theatresData,string ticketsData, IConfiguration configuration)
		{
			JsonSerializerSettings settings = new JsonSerializerSettings
			{
				ContractResolver = new PrivateSetterContractResolver()
			};
			List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(moviesData, settings);
			List<Theatre> theatres = JsonConvert.DeserializeObject<List<Theatre>>(theatresData, settings);
			List<Ticket> tickets = JsonConvert.DeserializeObject<List<Ticket>>(ticketsData, settings);
			var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
			connection.Open();
			using (var context = new Database(connection))
			{
				var moviesList = context.Fetch<Movie>("SELECT * FROM dbo.Movies");
				if (moviesList != movies)
				{
					foreach (var movie in movies)
					{
						if (context.Fetch<Movie>("select * from dbo.Movies where MovieId=@0", movie.MovieId).Any<Movie>())
						{
							context.Save("dbo.Movies", "MovieId", movie);
						}
						else
						{
							context.Insert("dbo.Movies", movie);
						}
					}

				}
				var theatreList = context.Fetch<Theatre>("SELECT * FROM dbo.Theatres");
				if (theatreList != theatres)
				{
					foreach (var theatre in theatres)
					{
						if (context.Fetch<Theatre>("select * from dbo.Theatres where TheatreId=@0", theatre.TheatreId).Any<Theatre>())
						{
							context.Save("dbo.Theatres", "TheatreId", theatre);
						}
						else
						{
							Console.WriteLine(theatre);
							context.Insert("dbo.Theatres", theatre);
						}
					}

				}
				var ticketList = context.Fetch<Ticket>("SELECT * FROM dbo.Tickets");
				if (ticketList != tickets)
				{
					foreach (var ticket in tickets)
					{
						if (context.Fetch<Ticket>("select * from dbo.Tickets where Id=@0", ticket.Id).Any<Ticket>())
						{
							context.Save("dbo.Tickets", "Id", ticket);
						}
						else
						{
							context.Insert("dbo.Tickets", ticket);
						}
					}

				}
			}
		}
	}
}
