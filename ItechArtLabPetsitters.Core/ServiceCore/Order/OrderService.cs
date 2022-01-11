using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Core.ServiceCore.Order
{
    public class OrderService : IOrdersService
    {
        private readonly IOrderRepository _OrdersRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _OrdersRepository = orderRepository;
        }
        public async Task<ActionResult> CancelDoerOrderAsync(long OrderID)
        {
            return await _OrdersRepository.CancelDoerOrderAsync(OrderID);
        }

        public async Task<ActionResult> CreateClientOrderAsync(OrderCreationModel model)
        {
            return await _OrdersRepository.CreateClientOrderAsync(model);
        }

        public async Task<ActionResult> DeleteOrderAsync(long OrderID)
        {
            return await _OrdersRepository.DeleteOrderAsync(OrderID);
        }

        public async Task<ActionResult> TakeDoerOrderAsync(long OrderID, long DoerID)
        {
            return await _OrdersRepository.TakeDoerOrderAsync(OrderID, DoerID);
        }
    }
}