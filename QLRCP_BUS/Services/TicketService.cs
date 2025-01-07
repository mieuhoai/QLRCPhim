using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
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
        private readonly UserRepository userRepository1;
        //private UserRepository userRepository1;
        public TicketService(ITicketRepository ticketRepository, MovieRepository movieRepository)
        {
            var Context = new MovieContextDB();
            this.ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            this.movieRepository = movieRepository ?? throw new ArgumentNullException(nameof(movieRepository));
            userRepository1 = new UserRepository(Context);
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
        public List<user_film> GetUserMovieTickets(int userId)
{
            try
            {
                // Lấy danh sách vé người dùng từ UserRepository
                var tickets = userRepository1.GetUserTickets(userId);
                List<user_film> user_films = new List<user_film>();

                // Duyệt qua danh sách vé và tạo đối tượng user_film
                foreach (var ticket in tickets)
                {
                    user_films.Add(new user_film
                    {
                        user_id = userId,
                        ticket_id = ticket.id,
                        seat_number = ticket.seat_number,
                        purchase_date = ticket.purchase_date
                    });
                }

                return user_films;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy thông tin vé: {ex.Message}");
                throw;
            }
        }


        public void AddBuyTicket_1(buy_tickets ticket, int userId)
        {
            try
            {
                if (ticketRepository.IsSeatAvailable(ticket.movie_id, ticket.seat_number))
                {
                    ticketRepository.AddBuyTicket(ticket,userId); // Gọi hàm thêm vé từ repository
                    Console.WriteLine($"Vé được thêm thành công: movie_id={ticket.movie_id}, seat_number={ticket.seat_number}");
                }
                else
                {
                    throw new InvalidOperationException("Ghế đã được đặt. Vui lòng chọn ghế khác.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm vé: {ex.Message}");
                throw; // Ném ngoại lệ để lớp gọi xử lý
            }
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
        public int GetTotalRevenue_1()
        {
            try
            {
                // Assuming the repository has a method to get all tickets
                var tickets = ticketRepository.GetAllTickets();
                return tickets.Sum(ticket => ticket.totalPrice ?? 0);  // Assuming 'price' is a property of 'buy_tickets'
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy tổng doanh thu: {ex.Message}");
                throw; // Ném lại ngoại lệ để lớp gọi xử lý
            }
        }

    }
}
