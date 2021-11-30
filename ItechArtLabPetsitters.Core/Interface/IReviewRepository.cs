using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IReviewRepository
    {
        public Task AddReviewAsync(ReviewCreationModel model);
        public Task<List<Review>> GetAllReviewAsync();
        public Task<List<Review>> GetReviewsForUser(long ID);
        public Task DeleteReviewAsync(long ID);
    }
}
