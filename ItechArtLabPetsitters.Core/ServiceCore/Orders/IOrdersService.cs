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
        public Task CreateClientOrderAsync(OrderCreationModel model);
        public Task DeleteOrderAsync(long OrderID);
        public Task TakeDoerOrderAsync(long OrderID, long DoerID);
        public Task CancelDoerOrderAsync(long OrderID);
        public Task<List<Order>> GetAvaliableOrderListAsync(PaginationSettingsModel paginationSettings);
        public Task<List<Order>> GetAllOrdersAsync(PaginationSettingsModel paginationSettings);
    }
}
