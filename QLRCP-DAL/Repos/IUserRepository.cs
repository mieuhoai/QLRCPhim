using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;

namespace QLRCP_DAL.Repos
{
    public interface IUserRepository
    {
        IEnumerable<user> GetAllUsers();
        IEnumerable<user> GetUsersByRole(string role);
        user GetUserById(int id);
        user GetUserByUsername(string username);
        void AddUser(user user);
        void UpdateUser(user user);
        void DeleteUser(int id);
        bool ValidateUser(string username, string password);
    }
}
