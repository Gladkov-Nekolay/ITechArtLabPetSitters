using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Core.Interface
{
    public interface IOrderRepository
    {
        public Task CreateClientOrderAsync(Order AddingOrder);
        public Task DeleteOrderAsync(long OrderID);
        public Task TakeDoerOrderAsync(long OrderID, long DoerID);
        public Task CancelDoerOrderAsync(long OrderID);
        public Task<List<Order>> GetAvaliableOrderListAsync(PaginationSettingsModel paginationSettings);
        public Task<List<Order>> GetAllOrdersListAsync(PaginationSettingsModel paginationSettings);
    }
}
