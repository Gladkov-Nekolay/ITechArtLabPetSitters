using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.ServiceCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServicesService service;

        public ServiceController(IServicesService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("services")]
        public Task<List<Service>> GetAll()
        {
            return service.GetAllServicesAsync();
        }
        [Route("{id}")]
        [HttpGet]
        public Task<Service> search(long id)
        {
            return service.SearchServiceAsync(id);
        }

        [HttpPost]
        public async Task PostServiceAsync(ServiceCreationModel model)
        {
            await service.AddServiceAsync(model);
        }
        [HttpDelete("DeleteService/{ID}")]
        public async Task DeleteServiceAsync(long ID)
        {
            await service.DeleteServiceAsync(ID);
        }
    }
}
