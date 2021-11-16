using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IPetsService
    {
        public Task AddPetAsync(string petName, string petType, byte age, string description);
        public Task DeletePetAsync(long ID);
        public Task<List<Pet>> GetAllPetsAsync(); 
    }
}
