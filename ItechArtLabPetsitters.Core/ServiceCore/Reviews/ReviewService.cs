using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;

namespace ItechArtLabPetsitters.Repository.ServiceCore.Reviews
{
    public class ReviewService:IReviewService
    {
        private readonly IReviewRepository _ReviewRepository;
        public ReviewService(IReviewRepository ReviewRepository)
        {
            _ReviewRepository = ReviewRepository;
        }
        public async Task AddReviewAsync(long petsitterID, long clientID, byte mark, string comment)
        {
            await _ReviewRepository.AddReviewAsync(petsitterID, clientID, mark, comment);
        }

        public async Task<List<Review>> GetAllReviewAsync()
        {
            return await _ReviewRepository.GetAllReviewAsync();
        }

        public async Task DeleteReviewAsync(long ID)
        {
            await _ReviewRepository.DeleteReviewAsync(ID);
        }
        public async Task<List<Review>> GetReviewsForUser(long ID) 
        {
            return await _ReviewRepository.GetReviewsForUser(ID);
        }
    }
}
