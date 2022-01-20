using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Core.ServiceCore.Orders
{
    public class OrderService : IOrdersService
    {
        private readonly IOrderRepository _OrdersRepository;
        private readonly IMapper mapper;
        public OrderService(IOrderRepository orderRepository,IMapper Mapper)
        {
            _OrdersRepository = orderRepository;
            mapper = Mapper;
        }
        public async Task CancelDoerOrderAsync(long OrderID)
        {
            await _OrdersRepository.CancelDoerOrderAsync(OrderID);
        }

        public async Task CreateClientOrderAsync(OrderCreationModel model)
        {
            Order MapedOrder = mapper.Map<OrderCreationModel, Order>(model);
            await _OrdersRepository.CreateClientOrderAsync(MapedOrder);
        }

        public async Task DeleteOrderAsync(long OrderID)
        {
            await _OrdersRepository.DeleteOrderAsync(OrderID);
        }

        public async Task TakeDoerOrderAsync(long OrderID, long DoerID)
        {
            await _OrdersRepository.TakeDoerOrderAsync(OrderID, DoerID);
        }
        public async Task<List<Order>> GetAvaliableOrderListAsync(PaginationSettingsModel paginationSettings) 
        {
            return await _OrdersRepository.GetAvaliableOrderListAsync(paginationSettings);
        }
        public async Task<List<Order>> GetAllOrdersAsync(PaginationSettingsModel paginationSettings) 
        {
            return await _OrdersRepository.GetAllOrdersListAsync(paginationSettings);
        }
    }
}