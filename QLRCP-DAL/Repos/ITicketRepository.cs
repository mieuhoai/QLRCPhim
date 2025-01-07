using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;

namespace QLRCP_DAL.Repos
{
    public interface ITicketRepository
    {
        IEnumerable<buy_tickets> GetAllTickets();
        buy_tickets GetTicketById(int id);
        IEnumerable<buy_tickets> GetTicketsByMovie(string movieId);
        void AddBuyTicket(buy_tickets ticket, int userId);
        void UpdateTicket(buy_tickets ticket);
        void DeleteTicket(int id);
        bool IsSeatAvailable(string movieId, int seatNumber);
        IEnumerable<TicketRepository.TicketWithMovieInfo> GetTicketsWithMovieInfo();
    }
}
