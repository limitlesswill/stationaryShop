using Models.Application.Models;
using Stationery.Context.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Application.Contracts
{
    public interface IOrderRepository: IRepository<Order, int>
    {
        StationeryContext context { get; }
    }
}
