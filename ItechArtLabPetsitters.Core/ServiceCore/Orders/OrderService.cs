using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Core.ServiceCore.Orders
{
    public class OrderService : IOrdersService
    {
        private readonly IOrderRepository _OrdersRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _OrdersRepository = orderRepository;
        }
        public async Task CancelDoerOrderAsync(long OrderID)
        {
            await _OrdersRepository.CancelDoerOrderAsync(OrderID);
        }

        public async Task CreateClientOrderAsync(OrderCreationModel model)
        {
            await _OrdersRepository.CreateClientOrderAsync(model);
        }

        public async Task DeleteOrderAsync(long OrderID)
        {
            await _OrdersRepository.DeleteOrderAsync(OrderID);
        }

        public async Task TakeDoerOrderAsync(long OrderID, long DoerID)
        {
            await _OrdersRepository.TakeDoerOrderAsync(OrderID, DoerID);
        }
        public async Task<List<Order>> GetAvaliableOrderListAsync() 
        {
            return await _OrdersRepository.GetAvaliableOrderListAsync();
        }
        public async Task<List<Order>> GetAllOrdersAsync() 
        {
            return await _OrdersRepository.GetAllOrdersListAsync();
        }
    }
}