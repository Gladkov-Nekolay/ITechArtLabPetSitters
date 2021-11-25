using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.ServiceCore.Reviews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService service;

        public ReviewController(IReviewService service)
        {
            this.service = service;
        }
        [HttpPost]
        public async Task AddReviewAsync(long petsitterID, long clientID, byte mark, string comment)
        {
            await service.AddReviewAsync(petsitterID, clientID, mark, comment);
        }
        [HttpDelete]
        public async Task DeleteReviewAsync(long ID)
        {
            await service.DeleteReviewAsync(ID);
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<List<Review>> GetAllReviewAsync()
        {
            return await service.GetAllReviewAsync();
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<List<Review>> GetReviewsForUser(long UserID)
        {
            return await service.GetReviewsForUser(UserID);
        }
    }
}
