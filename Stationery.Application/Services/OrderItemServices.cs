using Models.Application.Models;
using Stationery.Application.Contracts;
using Stationery.Application.Services.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services
{
    public class OrderItemServices : Services<OrderItem, int>, IOrderItemServices
    {
        IOrderItemRepository _OrderItemRepository;
        IOrderServices _OrderServices;
        IProductServices _ProductServices;

        public IOrderServices orderServices { get => _OrderServices; }
        public IProductServices productServices { get => _ProductServices; }
        public OrderItemServices(IOrderItemRepository OrderItemRepository, IOrderServices OrderServices
                                , IProductServices productServices) 
                                : base(OrderItemRepository)
        {
            _OrderItemRepository = OrderItemRepository;
            _OrderServices = OrderServices;
            _ProductServices = productServices;
        }

        public List<OrderItem> GetAllByOrderPagination(int OrderId)
        {
            if (OrderId <= 0)
            {
                throw new ArgumentException("Invalid user ID.");
            }

            return _OrderItemRepository.GetAll().ToList();
        }

        public override OrderItem Add(OrderItem entity)
        {
            UpdateOrderTotalAmount(entity);
            CheckAndAdjustProductAvailability(entity.ProductId, entity.Quantity);
            OrderItem addedItem = base.Add(entity);
            return addedItem;
        }

        private void UpdateOrderTotalAmount(OrderItem entity)
        {
            Order? order = _OrderServices.GetById(entity.OrderId);
            if (order != null)
            {
                decimal productPrice = GetProductPriceForOrderItem(entity.ProductId);
                decimal totalAmount = productPrice * entity.Quantity;

                order.TotalAmount += totalAmount;
                order = _OrderServices.Update(order);
            }
            else
            {
                throw new Exception("Order not found.");
            }
        }

        public void CheckAndAdjustProductAvailability(int productId, int quantity)
        {
            Product? product = _ProductServices.GetById(productId);
            if (product != null)
            {

                if ( product.AvailableQuantity <= 0)
                {
                    throw new Exception("Product is out of stock.");
                }

                if (product.AvailableQuantity < quantity)
                {
                    throw new Exception("Insufficient quantity available.");
                }

                product.AvailableQuantity -= quantity;
                _ProductServices.Update(product);
            }
           
        }

        private decimal GetProductPriceForOrderItem(int ProductId)
        {
            Product? product = _ProductServices.GetById(ProductId);

            if (product != null)
            {
                return product.Price;
            }
            else
            {
                throw new Exception($"Product with ID {ProductId} not found.");
            }
        }

        public int GetProductQuantityInOrder(int orderId, int productId)
        {
            var orderItems = _OrderItemRepository.GetAll().Where(oi => oi.OrderId == orderId && oi.ProductId == productId);
            int totalQuantity = orderItems.Sum(oi => oi.Quantity);
            return totalQuantity;
        }

    }
}

