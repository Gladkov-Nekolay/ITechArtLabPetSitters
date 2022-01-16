using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.ServiceCore.Reviews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService service;

        public ReviewController(IReviewService service)
        {
            this.service = service;
        }
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task <ActionResult> AddReviewAsync(ReviewCreationModel model)
        {
            if (!ModelState.IsValid) 
            {
                return ValidationProblem();
            }
            await service.AddReviewAsync(model);
            return new OkResult() ;
        }
        [Authorize(Roles = "User")]
        [HttpDelete]
        public async Task <ActionResult> DeleteReviewAsync(long ID)
        {
            await service.DeleteReviewAsync(ID);
            return new OkResult();
        }
        [Authorize(Roles = "Admin")]
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAllReviewAsync()
        {
            return new OkObjectResult (await service.GetAllReviewAsync());
        }
        [Authorize(Roles = "User")]
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetReviewsForUser(long UserID)
        {
            return new OkObjectResult(await service.GetReviewsForUser(UserID));
        }
    }
}
