using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class RewiewEFRepository:IReviewRepository
    {
        private readonly PetsittersContext _dbContext;
        public RewiewEFRepository(PetsittersContext context) => this._dbContext = context;

        public async Task AddReviewAsync(long petsitterID, long clientID, byte mark, string comment)
        {
            _dbContext.Reviews.Add(new Review(petsitterID,clientID,mark,comment));
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteReviewAsync(long ID)
        {
            Review DeletedReview = await _dbContext.Reviews.FirstAsync(p => p.ReviewID == ID);
            _dbContext.Reviews.Remove(DeletedReview);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Review>> GetAllReviewAsync()
        {
            return await _dbContext.Reviews.ToListAsync();
        }
        public async Task<List<Review>> GetReviewsForUser(long ID) 
        {
            return await _dbContext.Reviews.Where(p=>p.PetsitterID==ID).ToListAsync();
        }
    }
}
