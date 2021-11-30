using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IPetsService
    {
        public Task AddPetAsync(PetCreationModel model);
        public Task DeletePetAsync(long ID);
        public Task<List<Pet>> GetAllPetsAsync(); 
    }
}
