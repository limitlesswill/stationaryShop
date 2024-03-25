using Models.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Application.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? UserName { get; set; }
        public Role Role { get; set; }

        public string Password { get; set; }

        public required string Email { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public List<Order>? Orders { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }
        public override string ToString()
        {
            return UserName;
        }
    }
}
