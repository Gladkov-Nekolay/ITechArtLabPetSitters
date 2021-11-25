using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public OrderRepository(PetsittersContext context) => this._dbContext = context;

        public async Task CancelDoerOrderAsync(long OrderID)
        {
            Order TakeOreder = await _dbContext.Orders.FirstAsync(p => p.ID == OrderID);
            TakeOreder.PetsitterID = -1;
            _dbContext.Orders.Update(TakeOreder);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CreateClientOrderAsync(OrderModel model)
        {
            _dbContext.Orders.Add
                (new Order
                {
                    ServiceID=model.serviceID,
                    PetID=model.petID,
                    PetsitterID=model.petsitterID,
                    ClientID=model.clientID,
                    Comment=model.comment
                }
                );
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
