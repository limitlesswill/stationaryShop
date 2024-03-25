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
    public class CategoryServices: Services<Category,int>, ICategoryServices
    {
        private readonly ICategoryRepository _CategoryRepository;

        public CategoryServices(ICategoryRepository CategoryRepository):base(CategoryRepository) 
        {
            _CategoryRepository = CategoryRepository;
        }

    }
}
