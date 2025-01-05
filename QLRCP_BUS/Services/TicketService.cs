using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;
using QLRCP_DAL.Repos;

namespace QLRCP_BUS.Services
{
    public class TicketService
    {
        private readonly ITicketRepository ticketRepository;
        private readonly IMovieRepository movieRepository;

        public TicketService(ITicketRepository ticketRepository, IMovieRepository movieRepository)
        {
            ticketRepository = ticketRepository;
            movieRepository = movieRepository;
        }

        public List<buy_tickets> GetAllTickets()
        {
            var tickets = ticketRepository.GetAllTickets();
            return tickets.Select(MapToDTO).ToList();
        }

        public buy_tickets GetTicketById(int id)
        {
            var ticket = ticketRepository.GetTicketById(id);
            return ticket != null ? MapToDTO(ticket) : null;
        }

        public bool PurchaseTicket(string movieId, int seatNumber)
        {
            if (!ticketRepository.IsSeatAvailable(movieId, seatNumber))
                return false;

            var movie = movieRepository.GetMovieById(movieId.ToString());
            if (movie == null || movie.status != "Co san")
                return false;

            var ticket = new buy_tickets
            {
                movie_id = movieId.ToString(), // Fixing the type conversion issue here
                seat_number = seatNumber,
                purchase_date = DateTime.Now
            };

            ticketRepository.AddTicket(ticket);
            return true;
       
        }

        public bool CancelTicket(int ticketId)
        {
            var ticket = ticketRepository.GetTicketById(ticketId);
            if (ticket == null) return false;

            ticketRepository.DeleteTicket(ticketId);
            return true;
        }

        private buy_tickets MapToDTO(buy_tickets ticket)
        {
            var movie = movieRepository.GetMovieById(ticket.movie_id.ToString());
            return new buy_tickets
            {
                id = ticket.id,
                movie_id = ticket.movie_id,
                seat_number = ticket.seat_number,
                purchase_date = ticket.purchase_date,
              //  movie_name  = movie?.movie_name ?? "Unknown Movie",
            };
        }
    }
}
