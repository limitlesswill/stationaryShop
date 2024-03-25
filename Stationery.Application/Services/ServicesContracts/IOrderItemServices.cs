using Models.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services.ServicesContracts
{
    public interface IOrderItemServices : IServices<OrderItem, int>
    {
        List<OrderItem> GetAllByOrderPagination(int OrderId);
        public IOrderServices orderServices {  get; }
        public IProductServices productServices { get; }
        public int GetProductQuantityInOrder(int orderId, int productId);
        public void CheckAndAdjustProductAvailability(int productId, int quantity);
    }
}
