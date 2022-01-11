using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.ServiceCore.Reviews
{
    public interface IReviewService
    {
        public Task <ActionResult> AddReviewAsync(ReviewCreationModel model);
        public Task <ActionResult> DeleteReviewAsync(long ID);
        public Task<List<Review>> GetAllReviewAsync();
        public Task<List<Review>> GetReviewsForUser(long ID);
    }
}
