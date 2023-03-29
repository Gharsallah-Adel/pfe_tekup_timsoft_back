﻿using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Repository
{
    public interface IUserRepository
    {

        User GetCurrentUser();
        public User AddUser(UserForm user);
        public User UpdateUser(User user);
        public string RemoveUser(int id);
        public User? GetUserById(int id);
        public User AddRoles(List<string> roles , int userId);
        public List<User> GetAllUsers();
        public int GetUsersCount();
    }
}
