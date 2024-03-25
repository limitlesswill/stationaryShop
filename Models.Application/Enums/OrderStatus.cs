using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Application.Models
{
    public enum OrderStatus
    {
        Unconfirmed,
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}
