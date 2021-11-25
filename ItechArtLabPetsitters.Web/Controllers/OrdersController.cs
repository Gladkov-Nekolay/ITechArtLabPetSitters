using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Core.ServiceCore.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService service;
        public OrdersController(IOrdersService service)
        {
            this.service = service;
        }
        [HttpPut]
        [Route("[action]")]
        public async Task CancelDoerOrderAsync(long OrderID)
        {
            await service.CancelDoerOrderAsync(OrderID);
        }
        [HttpPost]
        public async Task CreateClientOrderAsync(OrderModel model)
        {
            await service.CreateClientOrderAsync(model);
        }
        [HttpDelete]
        public async Task DeleteOrderAsync(long OrderID)
        {
            await service.DeleteOrderAsync(OrderID);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task TakeDoerOrderAsync(long OrderID, long DoerID)
        {
            await service.TakeDoerOrderAsync(OrderID, DoerID);
        }


    }
}
