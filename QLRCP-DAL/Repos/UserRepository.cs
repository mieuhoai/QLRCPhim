using System;
using System.Collections.Generic;
using System.Linq;
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
            Context.users.Add(user);
            Context.SaveChanges();
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