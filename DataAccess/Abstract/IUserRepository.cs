using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();

        Users GetUserById(int id);

        Users CreateUser(Users User);

        Users UpdateUser(Users user);

        void Delete(int id);
    }
}
