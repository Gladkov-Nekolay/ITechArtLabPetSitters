using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IReviewRepository
    {
        public Task AddReviewAsync(long petsitterID, long clientID, byte mark, string comment);
        public Task<List<Review>> GetAllReviewAsync();
        public Task<List<Review>> GetReviewsForUser(long ID);
        public Task DeleteReviewAsync(long ID);
    }
}
