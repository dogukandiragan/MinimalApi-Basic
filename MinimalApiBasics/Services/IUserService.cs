﻿using MinimalApiBasics.Models;

namespace MinimalApiBasics.Services
{
   public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(int id, User user);
        void DeleteUser(int id);
    }
}
