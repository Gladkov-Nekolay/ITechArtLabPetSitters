using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.ServiceCore;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetsService service;
        public PetsController(IPetsService service)
        {
            this.service = service;
        }
        [HttpPost("Pets/{petName}")]
        public async Task AsyncPostPet(string petName, string petType, byte age, string description)
        {
            await service.AddPetAsync(petName, petType, age, description);
        }
        [HttpDelete]
        public async Task DeletePetAsync(long ID)
        {
            await service.DeletePetAsync(ID);
        }
        [HttpGet]
        [Route("Pets")]
        public Task<List<Pet>> GetAll()
        {
            return service.GetAllPetsAsync();
        }
    }
}
