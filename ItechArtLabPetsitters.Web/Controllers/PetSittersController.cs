using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Web.Repository;
using ItechArtLabPetsitters.Web.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetSittersController : ControllerBase
    {
        private readonly FakeRepository _fakeRepository = new FakeRepository();
        [HttpGet]
        public List<Service> GetAll() 
        {
            return _fakeRepository.GetAllServices();
        }

    }
}
