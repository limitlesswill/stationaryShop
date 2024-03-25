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
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("order")]
        public int OrderId { get; set; }
        public Order order { get; set; }
        [ForeignKey("product")]
        public int ProductId { get; set; }
        public Product product { get; set; }

        public int Quantity { get; set; }

       


    }
}
