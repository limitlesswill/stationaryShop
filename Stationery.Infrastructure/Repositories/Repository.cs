using Microsoft.EntityFrameworkCore;
using Stationery.Application.Contracts;
using Stationery.Context.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Infrastructure.Repositories
{
    public class Repository<T, TID> : IRepository<T, TID>where T : class
    {
        StationeryContext stationeryContext;
        DbSet<T> Dbset;
        public Repository (StationeryContext _stationeryContext)
        {
            stationeryContext = _stationeryContext;
            Dbset = stationeryContext.Set<T>();
        }
        public T Add(T entity)
        {
            var EntityAdded = Dbset.Add(entity).Entity;
            return EntityAdded;
        }

        public void Delete(T entity)
        {
            Dbset.Remove(entity);
           
        }

        public virtual IQueryable<T> GetAll()
        {
            var entities = Dbset;
            return entities;
        }

        public virtual T? GetById(TID id)
        {
            return Dbset.Find(id);
        }

        public int Save()
        {
            return stationeryContext.SaveChanges();
        }

        public T Update(T entity)
        {
            return Dbset.Update(entity).Entity;
        }
    }
}
