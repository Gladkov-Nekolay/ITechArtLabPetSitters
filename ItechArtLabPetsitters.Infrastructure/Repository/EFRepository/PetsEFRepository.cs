using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ItechArtLabPetsitters.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class PetsEFRepository : IPetsRepository
    {
        private readonly PetsittersContext _dbContext;
        private readonly IMapper mapper;
        public PetsEFRepository(PetsittersContext context, IMapper Mapper)
        {
            this._dbContext = context;
            this.mapper = Mapper;
        }
        public async Task<ActionResult> AddPetAsync(PetCreationModel model)
        {
            Pet AddedPet = mapper.Map<PetCreationModel, Pet>(model);
            _dbContext.Pets.Add(AddedPet);
            await _dbContext.SaveChangesAsync();
            return new OkResult();
        }

        public async Task<ActionResult> DeletePetAsync(long ID)
        {
            Pet deletedPet = await _dbContext.Pets.FirstAsync(p => p.ID == ID); 
            _dbContext.Pets.Remove(deletedPet);
            await _dbContext.SaveChangesAsync();
            return new OkResult();
        }
        public async Task<List<Pet>> GetAllPetsAsync()
        {
            return await _dbContext.Pets.ToListAsync();
        }
    }
}
