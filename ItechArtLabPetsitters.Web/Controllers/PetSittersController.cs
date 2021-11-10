using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.ServiceCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetSittersController : ControllerBase
    {
        private readonly IServicesService service;

        public PetSittersController(IServicesService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("sevices")]
        public Task<List<Service>> GetAll()
        {
            return service.AsyncGetAllServices();
        }
        [Route("{id}")]
        [HttpGet]
        public Task<Service> search(long id)
        {
            return service.AsyncSearchService(id);
        }

        [HttpPost("service/{name}")]
        public async Task AsyncPostService(string name, string description, decimal price)
        {
            await service.AsyncAddService(name, description, price);
        }
        [HttpDelete("DeleteService/{ID}")]
        public async Task AsyncDeleteService(long ID) 
        {
            await service.AsyncDeleteService(ID);
        }
    }
}
