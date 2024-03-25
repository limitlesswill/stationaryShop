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
    public class ProductServices : Services<Product, int>, IProductServices
    {
        IProductRepository _ProductRepository;

        public ProductServices(IProductRepository ProductRepository) : base(ProductRepository) {
            _ProductRepository = ProductRepository;
        }

        public List<Product> SearchByCategory(int categoryId)
        {
            return _ProductRepository.SearchByCategory(categoryId).ToList();
        }

        public List<Product> SearchByName(string name)
        {
            return _ProductRepository.SearchByName(name).ToList();
        }
        public override Product? GetById(int id)
        {
            return base.GetById(id);
        }

    }
}
