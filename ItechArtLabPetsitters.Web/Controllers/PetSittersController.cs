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
        public List<Service> GetAll()
        {
            return service.GetAllServices();
        }
        [Route("{id}")]
        [HttpGet]
        public Service search(long id)
        {
            return service.Search(id);
        }

        //[HttpPost("{name}&{description}")]
        //public void PostService(string name, string description)
        //{
        //    service.AddService(name, description);
        //}
    }
}
