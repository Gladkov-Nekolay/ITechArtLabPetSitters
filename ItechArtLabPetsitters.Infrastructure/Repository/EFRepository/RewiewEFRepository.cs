using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ItechArtLabPetsitters.Core.Models;
using AutoMapper;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class RewiewEFRepository:IReviewRepository
    {
        private readonly PetsittersContext _dbContext;
        private readonly IMapper mapper;
        public RewiewEFRepository(PetsittersContext context,IMapper Mapper)
        {
            this._dbContext = context;
            this.mapper = Mapper;
        }

        public async Task AddReviewAsync(ReviewCreationModel model)
        {
            Review AddedReview = mapper.Map<ReviewCreationModel, Review>(model);
            _dbContext.Reviews.Add(AddedReview);
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
