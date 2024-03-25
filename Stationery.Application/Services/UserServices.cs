using Models.Application.Models;
using Stationery.Application.Contracts;
using Stationery.Application.Services.ServicesContracts;
using Models.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services
{
    public class UserServices :IUserServices
    {
        IUserRepository _UserRepository;

        public UserServices(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }
        public User? Login(string username, string password)
        {
            User? user = _UserRepository.GetAll()
                       .FirstOrDefault(u => u.UserName == username && u.Password == password);
            return user;
        }

        public User SignUp(User user)
        {
            user.Role = Role.normal;
           User AddedUser = _UserRepository.Add(user);
        
            _UserRepository.Save();
            return AddedUser;
        }
    }
}
