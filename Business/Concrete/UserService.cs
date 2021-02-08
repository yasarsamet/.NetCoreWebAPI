using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Users CreateUser(Users User)
        {
            return _userRepository.CreateUser(User);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public List<Users> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public Users GetUserById(int id)
        {
            if (id >0 )
            {
                return _userRepository.GetUserById(id);
            }
            else
            {
                throw new Exception("ID birden Küçük olamaz");
            }
            
        }

        public Users Update(Users user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
