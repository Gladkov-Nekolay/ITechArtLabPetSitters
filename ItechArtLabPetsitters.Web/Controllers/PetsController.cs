using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.ServiceCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetsService service;
        public PetsController(IPetsService service)
        {
            this.service = service;
        }
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<ActionResult> AsyncPostPet(PetCreationModel model)
        {
            return await service.AddPetAsync(model);
        }
        [Authorize(Roles = "User")]
        [HttpDelete]
        public async Task<ActionResult> DeletePetAsync(long ID)
        {
            return await service.DeletePetAsync(ID);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("Pets")]
        public Task<List<Pet>> GetAll()
        {
            return service.GetAllPetsAsync();
        }
    }
}
