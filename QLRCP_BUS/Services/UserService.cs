﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;
using QLRCP_DAL.Repos;

namespace QLRCP_BUS.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository UserRepository)
        {
            userRepository = UserRepository;
        }

        public List<user> GetAllUsers()
        {
            var users = userRepository.GetAllUsers();
            return users.Select(MapTo).ToList();
        }

        public List<user> GetStaffUsers()
        {
            var staffUsers = userRepository.GetUsersByRole("staff");
            return staffUsers.Select(MapTo).ToList();
        }

        public user GetUserById(int id)
        {
            var user = userRepository.GetUserById(id);
            return user != null ? MapTo(user) : null;
        }

        public bool AddUser(user userDto)
        {
            if (userRepository.GetUserByUsername(userDto.username) != null)
            {
                return false;
            }

            var users = new user
            {
                username = userDto.username,
                password = userDto.password,
                role = userDto.role,
                status = userDto.status,
                date_reg = DateTime.Now
            };

            userRepository.AddUser(users);
            return true;
        }

        public bool UpdateUser(user userDto)
        {
            var existingUser = userRepository.GetUserById(userDto.id);
            if (existingUser == null) return false;

            existingUser.username = userDto.username;
            existingUser.password = userDto.password;
            existingUser.status = userDto.status;
            // Role is typically not updated

            userRepository.UpdateUser(existingUser);
            return true;
        }

        public bool DeleteUser(int id)
        {
            var user = userRepository.GetUserById(id);
            if (user == null) return false;

            userRepository.DeleteUser(id);
            return true;
        }

        public bool ValidateLogin(string username, string password)
        {
            return userRepository.ValidateUser(username, password);
        }

        private user MapTo(user User)
        {
            return new user
            {
                id = User.id,
                username = User.username,
                password = User.password,
                role = User.role,
                status = User.status,
                date_reg = User.date_reg,
            };
        }
    }
}