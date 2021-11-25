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
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }
        [HttpPost]
        public async Task CreateUserAsync(UserModel model) 
        {
            await service.CreateUserAsync(model);
        }
        [HttpDelete]
        public async Task DeleteUserAsync(long ID) 
        {
            await service.DeleteUserAsync(ID);
        }
        [HttpGet]
        public async Task<List<User>> GetAllUsersAsync() 
        {
            return await service.GetAllUsersAsync();
        }
    }
}
