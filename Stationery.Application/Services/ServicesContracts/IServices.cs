using Models.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Services.ServicesContracts
{
    public interface IServices<T, TID>
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        PaginationResultViewModel<T> Pagination(int numberOfEntities, int pageIndex, List<T> ListNeedToPagination);
        List<T> GetAll();
        T? GetById(TID id);
    }
}
