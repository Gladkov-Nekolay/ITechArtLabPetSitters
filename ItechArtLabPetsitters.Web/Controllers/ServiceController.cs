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
    public class ServiceController : ControllerBase
    {
        private readonly IServicesService service;

        public ServiceController(IServicesService service)
        {
            this.service = service;
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        [Route("services")]
        public async Task<ActionResult> GetAll()
        {
            return new OkObjectResult(await service.GetAllServicesAsync());
        }
        [Authorize(Roles = "User")]
        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult> search(long id)
        {
            Service Result = await service.SearchServiceAsync(id);
            if (Result == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(Result);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult> PostServiceAsync(ServiceCreationModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }
            await service.AddServiceAsync(model); // не ясно как проверить добавился ли объект
            return new OkResult();
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("DeleteService/{ID}")]
        public async Task<ActionResult> DeleteServiceAsync(long ID) 
        {
            await service.DeleteServiceAsync(ID); // не ясно что возвращать и как проверить и как проверить удалился ли объект
            return new OkResult();
        }
    }
}
