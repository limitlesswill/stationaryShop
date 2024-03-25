using Models.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Contracts
{
    public interface IOrderItemRepository:IRepository<OrderItem, int>
    {
    }
}
