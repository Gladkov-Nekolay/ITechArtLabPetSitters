using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.ServiceCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }
        [AllowAnonymous]
        [Route("[action]")]
        [HttpPost]
        public async Task CreateUserAsync(UserCreationModel model)
        {
           await service.RegisterAsync(model);
        }
        [Authorize(Roles = "User")]
        [Route("[action]")]
        [HttpDelete]
        public async Task DeleteUserAsync(long ID)
        {

        }
        [Authorize(Roles = "Admin")]
        [Route("[action]")]
        [HttpGet]
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await service.GetAllUsersAsync();
        }
        [AllowAnonymous]
        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserAuthentificationModel model) 
        {
            if (!ModelState.IsValid) 
            {
                return new BadRequestObjectResult("Data is invalid");
            }
            return Ok(await service.LoginUserAsync(model));
        }
    }
}
