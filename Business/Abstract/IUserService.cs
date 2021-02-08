using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<Users> GetAllUsers();

        Users GetUserById(int id);

        Users CreateUser(Users User);

        Users Update(Users user);

        void Delete(int id);
    }
}
