using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;

namespace ItechArtLabPetsitters.Core.ServiceCore.Order
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

        public async Task CreateClientOrderAsync(OrderModel model)
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
    }
}