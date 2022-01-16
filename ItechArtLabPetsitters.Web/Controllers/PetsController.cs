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
            await service.AddPetAsync(model);
            return new OkResult();
        }
        [Authorize(Roles = "User")]
        [HttpDelete]
        public async Task<ActionResult> DeletePetAsync(long ID)
        {
            await service.DeletePetAsync(ID);
            return new OkResult();
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        [Route("UserPets")]
        public async Task<ActionResult> GetUserPets(long userID)
        {
            return new OkObjectResult(await service.GetUserPetsAsync(userID));
        }
    }
}
