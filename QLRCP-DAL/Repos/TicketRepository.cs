using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;

namespace QLRCP_DAL.Repos
{
    public class TicketRepository : ITicketRepository
    {
        private readonly MovieContextDB Context;

        public TicketRepository(MovieContextDB context)
        {
            Context = context;
        }


        public void DeleteTicket(int id)
        {
            var ticket = Context.buy_tickets.Find(id);
            if (ticket != null)
            {
                Context.buy_tickets.Remove(ticket);
                Context.SaveChanges();
            }
        }

        public bool IsSeatAvailable(string movieId, int seatNumber)
        {
            return !Context.buy_tickets.Any(t =>
                t.movie_id == movieId && t.seat_number == seatNumber
            );
        }

        public class TicketWithMovieInfo
        {
            public int Id { get; set; }
            public int MovieId { get; set; }
            public string MovieName { get; set; }
            public int SeatNumber { get; set; }
            public DateTime PurchaseDate { get; set; }
        }

        public IEnumerable<TicketWithMovieInfo> GetTicketsWithMovieInfo()
        {
            return Context.buy_tickets
            .Join(
                Context.movies,
                ticket => ticket.movie_id,
                movie => movie.movie_id,
                (ticket, movie) => new TicketWithMovieInfo
                {
                    Id = ticket.id,
                    MovieId = movie.id, // Fix: Use movie.id instead of ticket.movie_id
                    MovieName = movie != null ? movie.movie_name : "Unknown Movie",
                    SeatNumber = ticket.seat_number,
                    PurchaseDate = ticket.purchase_date ?? DateTime.MinValue, // Explicit conversion
                })
            .ToList();
        }

        IEnumerable<buy_tickets> ITicketRepository.GetAllTickets()
        {
            return Context.buy_tickets
                .Join(
                    Context.movies,
                    ticket => ticket.movie_id,
                    movie => movie.movie_id,
                    (ticket, movie) => ticket)
                .ToList();
        }

        buy_tickets ITicketRepository.GetTicketById(int id)
        {
            return Context.buy_tickets
                .Join(
                    Context.movies,
                    ticket => ticket.movie_id,
                    movie => movie.movie_id,
                    (ticket, movie) => ticket)
                .FirstOrDefault(t => t.id == id);
        }

        IEnumerable<buy_tickets> ITicketRepository.GetTicketsByMovie(string movieId)
        {
            return Context.buy_tickets
                .Where(t => t.movie_id == movieId)
                .ToList();
        }

        

        public void UpdateTicket(buy_tickets ticket)
        {
            var existingTicket = Context.buy_tickets.Find(ticket.id);
            if (existingTicket != null)
            {
                Context.Entry(existingTicket).CurrentValues.SetValues(ticket);
                Context.SaveChanges();
            }
        }
        public buy_tickets GetTicketBySeatAndMovie(string movieId, int seatNumber)
        {
            return Context.buy_tickets
                .FirstOrDefault(t => t.movie_id == movieId &&
                                   t.seat_number == seatNumber);
        }

        public void AddBuyTicket(buy_tickets ticket,int userId)
        {
            try
            {
                // Gán user_id vào vé
                ticket.user_id = userId;

                // Thêm thông tin vé vào bảng buy_tickets
                Context.buy_tickets.Add(ticket);

                // Lưu thay đổi vào cơ sở dữ liệu
                Context.SaveChanges();

                Console.WriteLine($"Vé được thêm thành công: movie_id={ticket.movie_id}, seat_number={ticket.seat_number}");
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu có vấn đề xảy ra
                Console.WriteLine($"Lỗi khi thêm vé: {ex.Message}");
                throw; // Ném lại ngoại lệ để lớp gọi xử lý
            }
        }
        
    }
}
