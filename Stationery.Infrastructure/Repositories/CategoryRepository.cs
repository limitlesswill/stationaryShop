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
    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        StationeryContext stationeryContext;
        public CategoryRepository(StationeryContext _stationeryContext) : base(_stationeryContext)
        {
            stationeryContext = _stationeryContext;
        }
    }
}
