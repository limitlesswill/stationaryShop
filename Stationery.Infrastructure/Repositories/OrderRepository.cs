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
    public class OrderRepository : Repository<Order, int>, IOrderRepository
    {
        StationeryContext stationeryContext;
        public OrderRepository(StationeryContext _stationeryContext) : base(_stationeryContext)
        {
            stationeryContext = _stationeryContext;
        }
        public override IQueryable<Order> GetAll()
        {
            return stationeryContext.Orders.Include(o => o.User);
        }
        public StationeryContext context { get => stationeryContext; }
    }
}
