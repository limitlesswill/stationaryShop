using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Application.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product>? Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
