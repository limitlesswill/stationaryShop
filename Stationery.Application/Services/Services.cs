using Models.Application.ViewModels;
using Stationery.Application.Contracts;
using Stationery.Application.Services.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services
{
    public class Services<T, TID> : IServices<T, TID> where T : class
    {
        protected readonly IRepository<T, TID> _repository;

        public Services(IRepository<T, TID> repository)
        {
            _repository = repository;
        }

        public virtual T Add(T entity)
        {
            T entityT = _repository.Add(entity);
            _repository.Save();
            return entityT;
        }

        public virtual void Delete(T entity)
        {
            _repository.Delete(entity);
            _repository.Save();
        }

        public virtual PaginationResultViewModel<T> Pagination(int numberOfEntities, int pageIndex,List<T> ListNeedToPagination)
        {
            List<T> entites =  ListNeedToPagination.Skip(numberOfEntities * pageIndex)
                .Take(numberOfEntities)
                .ToList();

            return new PaginationResultViewModel<T>()
            {
                Entities = entites,
                pageIndex = pageIndex,
                TotalPagesCount =(int) Math.Ceiling((decimal)ListNeedToPagination?.Count / (numberOfEntities>0? numberOfEntities:1)) 
            };
        }

        public virtual List<T> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public virtual T? GetById(TID id)
        {
            return _repository.GetById(id);
        }

        public virtual T Update(T entity)
        {
            T entityT = _repository.Update(entity);
            _repository.Save();
            return entityT;
        }
    }
}
