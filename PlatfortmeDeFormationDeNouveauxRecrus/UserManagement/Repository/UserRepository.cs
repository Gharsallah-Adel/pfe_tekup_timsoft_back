﻿using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.Utils;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext dataBase;

        public UserRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }


        public User AddRoles(List<string> roles, int userId)
        {
            List<Role> rolesUpd = new List<Role>();
            List<Role> rolesDb = new List<Role> { };

            rolesDb = dataBase.Roles.ToList<Role>();

            foreach (Role role in rolesDb)
            {
                if (roles.Contains(role.Name))
                {
                    rolesUpd.Add(role);
                }
            }


            foreach (Role role in rolesUpd)
            {
                System.Diagnostics.Debug.WriteLine(role.Name);
            }
            User dbuser = dataBase.Users.FirstOrDefault(u => u.User_id == userId);
            //System.Diagnostics.Debug.WriteLine(role);
            dbuser.Roles = new List<Role> { };
            dbuser.Roles.AddRange(rolesUpd);
            dataBase.Users.Update(dbuser);
            dataBase.SaveChanges();
            return dbuser;
        }
        public User AddUser(UserForm user)
        {
            User dbuser = new User();
            System.Diagnostics.Debug.WriteLine(user.FirstName.Length);
         
            dbuser.FirstName = user.FirstName;

           

            dbuser.LastName = user.LastName;


            

            if(dataBase.Users.Where(u => u.UserName.Contains(user.UserName)).Count() == 1)
            {
                throw new Exception("UserName Used !!");
            }

            var department = dataBase.Departements.Where(d => d.DepartementName == user.Department.ToString()).FirstOrDefault();
            //dbuser.Departement = department;

            dbuser.UserName = user.UserName;
            
            if(user.Password.Length < 4)
            {
                throw new Exception(" password must be longer then 6 caractere ");
            }


            dbuser.Password = HashPassword.HashPass(user.Password);

            List<Role> roles = new List<Role> { };

            dbuser.Roles = new List<Role> { };
            //dbuser.Roles.Add(role);

            dataBase.Users.Add(dbuser);

           dataBase.SaveChanges();
            return dbuser;
        }

        public int GetUsersCount()
        {
            return dataBase.Users.Count();
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();    
            users = dataBase.Users.ToList();
            return users;
        }

        public User GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        public User? GetUserById(int id)
        {
            return dataBase.Users.Find(id);
        }

        public string RemoveUser(int id)
        {
            User delUser = dataBase.Users.Where(d => d.User_id == id).FirstOrDefault();
            dataBase.Users.Remove(delUser);
            dataBase.SaveChanges();
            return "deleted successfully";
        }

            public User UpdateUser(User user)
        {
               User oldUser = GetUserById(user.User_id);
            if (oldUser == null)
            {
                oldUser = user;
            }
            dataBase.Users.Update(oldUser);
            dataBase.SaveChanges();
            return oldUser;
        }
    }
}
