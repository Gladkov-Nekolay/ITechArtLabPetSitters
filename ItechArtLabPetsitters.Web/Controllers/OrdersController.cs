using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Core.ServiceCore.Orders;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService service;
        public OrdersController(IOrdersService service)
        {
            this.service = service;
        }
        [Authorize(Roles = "Petsitter")]
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> CancelDoerOrderAsync(long OrderID)
        {
            await service.CancelDoerOrderAsync(OrderID);
            return new OkResult();
        }
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<ActionResult> CreateClientOrderAsync(OrderCreationModel model)
        {
            await service.CreateClientOrderAsync(model);
            return new OkResult();
        }
        [Authorize(Roles = "User")]
        [HttpDelete]
        public async Task<ActionResult> DeleteOrderAsync(long OrderID)
        {
            await service.DeleteOrderAsync(OrderID);
            return new OkResult();
        }
        [Authorize(Roles = "Petsitter")]
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> TakeDoerOrderAsync(long OrderID, long DoerID)
        {
            await service.TakeDoerOrderAsync(OrderID, DoerID);
            return new OkResult();
        }
        [Authorize(Roles = "Petsitter")]
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult> GetAvaliableOrderListAsync() 
        {
            return new OkObjectResult(await service.GetAvaliableOrderListAsync());
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult> GetAllOrdersListAsync()
        {
            return new OkObjectResult(await service.GetAllOrdersAsync());
        }
    }
}
