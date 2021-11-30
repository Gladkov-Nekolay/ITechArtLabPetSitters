using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
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
        [HttpPost]
        public async Task AsyncPostPet(PetCreationModel model)
        {
            await service.AddPetAsync(model);
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
