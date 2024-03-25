using Models.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services.ServicesContracts
{
    public interface IUserServices
    {
        User SignUp(User user);
        User? Login(string username, string password);
    }
}
