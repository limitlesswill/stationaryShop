using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Application.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public decimal Price { get; set; }

        public int AvailableQuantity { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Product()
        {
            OrderItems = new List<OrderItem>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
