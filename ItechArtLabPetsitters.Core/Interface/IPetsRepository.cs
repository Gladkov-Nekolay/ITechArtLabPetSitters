using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IPetsRepository
    {
        public Task AddPetAsync(string petName, string petType, byte age, string description, long OwnerID);
        public Task<List<Pet>> GetAllPetsAsync();
        public Task DeletePetAsync(long ID);
    }
}
