using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.ServiceCore.Clients;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService service;
        public ClientsController(IClientService service)
        {
            this.service = service;
        }
        [HttpPost("Client/{clientName}")]
        public async Task AsyncPostClient(string clientName, string phone)
        {
            await service.AsyncAddClient(clientName, phone);
        }
        [HttpDelete]
        public async Task AsyncDeleteClient(long ID)
        {
            await service.AsynkDeleteClient(ID);
        }
        [HttpGet]
        [Route("Clients")]
        public Task<List<Client>> GetAll()
        {
            return service.AsyncGetAllClients();
        }
    }
}
