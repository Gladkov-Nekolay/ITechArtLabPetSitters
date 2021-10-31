using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Web.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetSittersController : ControllerBase
    {
        private readonly FakeRepository _fakeRepository = new FakeRepository(); // нарушение архитектуры(проблемы для теста)
        //private readonly *интерфейс* *имя* 
        [HttpGet]
        [Route("sevices")]
        public List<Service> GetAll()
        {
            return _fakeRepository.GetAllServices();
        }
        [Route("{id}")]
        [HttpGet]
        public Service search(long id)
        {
            return _fakeRepository.Search(id);
        }

        [HttpPost("{name}&{description}")]
        public void PostService(string name, string description)
        {
            _fakeRepository.AddService(name, description);
        }
    }
}
