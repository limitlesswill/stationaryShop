using Models.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services.ServicesContracts
{
    public interface IOrderServices :IServices<Order, int>
    {
        public Order GetOrCreateUnconfirmedOrder(int userId);
        List<Order> GetByUser(int UserId);
        public void ConfirmOrder(int orderId);
        public void UpdateOrderStatus(int orderId, OrderStatus newStatus);

    }
}
