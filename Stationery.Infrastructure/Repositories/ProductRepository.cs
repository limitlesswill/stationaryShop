using Microsoft.EntityFrameworkCore;
using Models.Application.Models;
using Stationery.Application.Contracts;
using Stationery.Context.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        StationeryContext stationeryContext;
        public ProductRepository(StationeryContext _stationeryContext) : base(_stationeryContext)
        {
            stationeryContext = _stationeryContext;
        }
        public override IQueryable<Product> GetAll()
        {
            return stationeryContext.Products.Include(p => p.Category);
        }

        public IQueryable<Product> SearchByCategory(int categoryId)
        {
            return stationeryContext.Products.Where(p => p.CategoryId == categoryId);
        }

        public IQueryable<Product> SearchByName(string name)
        {
            return stationeryContext.Products.Where(p => p.Name.Contains(name));
        }
        public override Product? GetById(int id)
        {
            return stationeryContext.Products.Include(pro => pro.Category).FirstOrDefault(pro=>pro.ProductId== id);
        }
    }
}
