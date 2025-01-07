using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;

namespace QLRCP_DAL.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly MovieContextDB Context;

        public UserRepository(MovieContextDB context)
        {
            Context = context;
        }

        public IEnumerable<user> GetAllUsers()
        {
            return Context.users.Where(u => u.status != "Deleted").ToList();
        }

        public void DeleteUser(int id)
        {
            var user = Context.users.Find(id);
            if (user != null)
            {
                user.status = "Deleted";
                Context.SaveChanges();
            }
        }
        public IEnumerable<buy_tickets> GetUserTickets(int userId)
        {
            try
            {
                // Lấy danh sách vé của người dùng từ bảng buy_tickets
                var userTickets = Context.buy_tickets
                    .Where(t => t.user_id == userId)  // Lọc theo userId
                    .ToList();

                return userTickets;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách vé của người dùng: {ex.Message}");
                throw;
            }
        }
        public bool ValidateUser(string username, string password)
        {
            return Context.users.Any(u =>u.username == username &&u.password == password &&u.status != "Deleted"
            );
        }

        IEnumerable<user> IUserRepository.GetUsersByRole(string role)
        {
            return Context.users.Where(u => u.role == role && u.status != "Deleted").ToList();
        }

        user IUserRepository.GetUserById(int id)
        {
            return Context.users.Find(id);
        }

        user IUserRepository.GetUserByUsername(string username)
        {
            return Context.users.FirstOrDefault(u => u.username == username);
        }

        public void AddUser(user user)
        {
            try
            {
                // Kiểm tra xem user có hợp lệ hay không (ví dụ: username không null)
                if (user == null || string.IsNullOrEmpty(user.username) || string.IsNullOrEmpty(user.password))
                {
                    throw new ArgumentException("Thông tin người dùng không hợp lệ.");
                }

                // Thêm user vào cơ sở dữ liệu
                Context.users.Add(user);
                Context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                // Nếu có lỗi, ném lỗi chi tiết ra ngoài
                throw new Exception("Lỗi khi lưu người dùng vào cơ sở dữ liệu: " + ex.Message, ex);
            }
        }

        public void UpdateUser(user user)
        {
            var existingUser = Context.users.Find(user.id);
            if (existingUser != null)
            {
                Context.Entry(existingUser).CurrentValues.SetValues(user);
                Context.SaveChanges();
            }
        }
    }
}