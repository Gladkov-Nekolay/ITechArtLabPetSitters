using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IReviewRepository
    {
        public Task <ActionResult> AddReviewAsync(ReviewCreationModel model);
        public Task<List<Review>> GetAllReviewAsync();
        public Task<List<Review>> GetReviewsForUser(long ID);
        public Task DeleteReviewAsync(long ID);
    }
}
