using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Core.ServiceCore.Orders
{
    public interface IOrdersService
    {
        public Task<ActionResult> CreateClientOrderAsync(OrderCreationModel model);
        public Task<ActionResult> DeleteOrderAsync(long OrderID);
        public Task<ActionResult> TakeDoerOrderAsync(long OrderID, long DoerID);
        public Task<ActionResult> CancelDoerOrderAsync(long OrderID);
        public Task<List<Order>> GetAvaliableOrderListAsync();
        public Task<List<Order>> GetAllOrdersAsync();
    }
}
