using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class OrderRepository: IOrderRepository
    {
        private readonly PetsittersContext _dbContext;
        private readonly IMapper mapper;
        public OrderRepository(PetsittersContext context, IMapper Mapper)
        {
            this._dbContext = context;
            this.mapper = Mapper;
        }

        public async Task CancelDoerOrderAsync(long OrderID)
        {
            Order TakeOreder = await _dbContext.Orders.FirstAsync(p => p.ID == OrderID);
            TakeOreder.PetsitterID = -1;
            _dbContext.Orders.Update(TakeOreder);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CreateClientOrderAsync(OrderCreationModel model)
        {
            _dbContext.Orders.Add(mapper.Map<OrderCreationModel, Order>(model));
            await _dbContext.SaveChangesAsync(); 
        }

        public async Task DeleteOrderAsync(long OrderID)
        {
            Order deletedOrder = await _dbContext.Orders.FirstAsync(p => p.ID == OrderID);
            _dbContext.Orders.Remove(deletedOrder);
            await _dbContext.SaveChangesAsync();
        }

        public async Task TakeDoerOrderAsync(long OrderID, long DoerID)
        {
            Order TakeOreder = await _dbContext.Orders.FirstAsync(p => p.ID == OrderID);
            TakeOreder.PetsitterID = DoerID;
            _dbContext.Orders.Update(TakeOreder);
            await _dbContext.SaveChangesAsync();
        }
    }
}
