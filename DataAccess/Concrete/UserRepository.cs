using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public Users CreateUser(Users User)
        {
            using (var userDbContext = new VTDbContext())
            {
                userDbContext.User.Add(User);
                userDbContext.SaveChanges();
                return User;
            }
        }
        public void Delete(int id)
        {
            using (var userDbContext = new VTDbContext())
            {
                var deleted = GetUserById(id);
                userDbContext.User.Remove(deleted);
                userDbContext.SaveChanges();
            }
        }

        public List<Users> GetAllUsers()
        {
            using (var userDbContext=new VTDbContext())
            {
                return userDbContext.User.ToList();
            }                
        }

        public Users GetUserById(int id)
        {
            using (var userDbcontext = new VTDbContext())
            {
                return userDbcontext.User.Find(id);
            }                
        }
        public Users UpdateUser(Users user)
        {
            using (var userDbContext = new VTDbContext())
            {
                userDbContext.User.Update(user);
                userDbContext.SaveChanges();
                return user;
            }                
        }
    }
}
