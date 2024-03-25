using Models.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services.ServicesContracts
{
    public interface IProductServices : IServices<Product, int>
    {
        List<Product> SearchByName(string name);
        List<Product> SearchByCategory(int categoryId);
    }
}
