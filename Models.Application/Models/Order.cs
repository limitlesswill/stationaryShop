using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Application.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime DateTime { get; set; }

        public OrderStatus Status { get; set; }

        public decimal TotalAmount { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User? User { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public override string ToString()
        {
            return $"cart created in {DateTime}";
        }
    }
}
