using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Core.ServiceCore.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase // ToDo add view all orders for petsitters
    {
        private readonly IOrdersService service;
        public OrdersController(IOrdersService service)
        {
            this.service = service;
        }
        [Authorize(Roles = "Petsitter")]
        [HttpPut]
        [Route("[action]")]
        public async Task CancelDoerOrderAsync(long OrderID)
        {
            await service.CancelDoerOrderAsync(OrderID);
        }
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task CreateClientOrderAsync(OrderCreationModel model)
        {
            await service.CreateClientOrderAsync(model);
        }
        [Authorize(Roles = "User")]
        [HttpDelete]
        public async Task DeleteOrderAsync(long OrderID)
        {
            await service.DeleteOrderAsync(OrderID);
        }
        [Authorize(Roles = "Petsitter")]
        [HttpPut]
        [Route("[action]")]
        public async Task TakeDoerOrderAsync(long OrderID, long DoerID)
        {
            await service.TakeDoerOrderAsync(OrderID, DoerID);
        }


    }
}
