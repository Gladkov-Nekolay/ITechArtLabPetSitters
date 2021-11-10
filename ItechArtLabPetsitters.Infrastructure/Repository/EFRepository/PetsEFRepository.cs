using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.ServiceCore;
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class PetsEFRepository : IPetsRepository
    {
        private readonly PetsittersContext _dbContext;
        public PetsEFRepository(PetsittersContext context) => this._dbContext = context;
        public async Task AsyncAddPet(string petName, string petType, byte age, string description)
        {
            _dbContext.Pets.Add(new Pet(petName, petType, age, description));
            await _dbContext.SaveChangesAsync(); ;
        }

        public async Task AsyncDeletePet(long ID)
        {
            Pet deletedPet = await _dbContext.Pets.FirstAsync(p => p._ID == ID); ;
            _dbContext.Pets.Remove(deletedPet);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Pet>> AsyncGetAllPets()
        {
            return await _dbContext.Pets.ToListAsync();
        }
    }
}
