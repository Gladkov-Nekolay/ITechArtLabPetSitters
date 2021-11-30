using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IPetsRepository
    {
        public Task AddPetAsync(PetCreationModel model);
        public Task<List<Pet>> GetAllPetsAsync();
        public Task DeletePetAsync(long ID);
    }
}
