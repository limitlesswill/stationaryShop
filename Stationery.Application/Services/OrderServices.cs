using Microsoft.EntityFrameworkCore;
using Models.Application.Models;
using Stationery.Application.Contracts;
using Stationery.Application.Services.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services
{
    public class OrderServices : Services<Order, int>, IOrderServices
    {
        IOrderRepository _OrderRepository;


        public OrderServices(IOrderRepository OrderRepository) : base(OrderRepository) 
        {
            _OrderRepository = OrderRepository;
        }
        public List<Order> GetByUser(int UserId)
        {
            if (UserId <= 0)
            {
                throw new ArgumentException("Invalid user ID.");
            }

            return _OrderRepository.GetAll()
                              .Where(order => order.UserId == UserId)
                              .ToList();
        }

        public Order GetOrCreateUnconfirmedOrder(int userId)
        {
            Order? unconfirmedOrder = _repository.GetAll().Include(order=>order.OrderItems).ThenInclude(item=>item.product)
                .FirstOrDefault(o => o.UserId == userId && o.Status == OrderStatus.Unconfirmed);

            if (unconfirmedOrder == null)
            {
                unconfirmedOrder = new Order
                {
                    UserId = userId,
                    DateTime = DateTime.UtcNow,
                    Status = OrderStatus.Unconfirmed,
                    TotalAmount = 0 
                };

                _repository.Add(unconfirmedOrder);
                _repository.Save();
            }

            return unconfirmedOrder;
        }

        public void ConfirmOrder(int orderId)
        {
            Order? order = _OrderRepository.GetById(orderId);
            if (order == null)
            {
                throw new ArgumentException("Invalid order ID.");
            }

            order.Status = OrderStatus.Pending;
            order.DateTime = DateTime.UtcNow;

            decimal totalAmount = CalculateOrderTotal(order);
            order.TotalAmount = totalAmount;

            _OrderRepository.Update(order);
            _OrderRepository.Save();
        }

        public decimal CalculateOrderTotal(Order order)
        {
            decimal totalAmount = 0;
            foreach (var orderItem in order.OrderItems)
            {
                totalAmount += orderItem.Quantity * orderItem.product.Price;
            }
            return totalAmount;
        }


        public void UpdateOrderStatus(int orderId, OrderStatus newStatus)
        {
            Order? order = _OrderRepository.GetById(orderId);
            if (order == null)
            {
                throw new ArgumentException("Invalid order ID.");
            }

            order.Status = newStatus;

            _OrderRepository.Update(order);
            _OrderRepository.Save();
        }

        public List<Order> GetByuserPagination(int UserId, int numberOfOrders, int PageIndex)
        {
            throw new NotImplementedException();
        }



        //public override Order Update(Order entity)
        //{
        //    throw new NotSupportedException("Direct updates to orders are not allowed. Use ConfirmOrder or UpdateOrderStatus instead.");
        //}


    }
    
}
