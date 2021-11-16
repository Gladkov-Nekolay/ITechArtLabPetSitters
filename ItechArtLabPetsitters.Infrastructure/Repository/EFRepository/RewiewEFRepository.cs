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
            Review deletedClient = await _dbContext.Reviews.FirstAsync(p => p.ReviewID == ID);
            _dbContext.Reviews.Remove(deletedClient);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Review>> GetAllReviewAsync()
        {
            return await _dbContext.Reviews.ToListAsync();
        }
    }
}
