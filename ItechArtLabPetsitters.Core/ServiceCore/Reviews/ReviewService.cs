﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.ServiceCore.Reviews
{
    public class ReviewService:IReviewService
    {
        private readonly IReviewRepository _ReviewRepository;
        public ReviewService(IReviewRepository ReviewRepository)
        {
            _ReviewRepository = ReviewRepository;
        }
        public async Task <ActionResult> AddReviewAsync(ReviewCreationModel model)
        {
            return await _ReviewRepository.AddReviewAsync(model);
        }

        public async Task<List<Review>> GetAllReviewAsync()
        {
            return await _ReviewRepository.GetAllReviewAsync();
        }

        public async Task <ActionResult> DeleteReviewAsync(long ID)
        {
            return await _ReviewRepository.DeleteReviewAsync(ID);
        }
        public async Task<List<Review>> GetReviewsForUser(long ID) 
        {
            return await _ReviewRepository.GetReviewsForUser(ID);
        }
    }
}
