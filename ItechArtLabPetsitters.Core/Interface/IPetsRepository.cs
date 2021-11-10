using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Core.Interface
{
    public interface IPetsRepository
    {
        public Task AsyncAddPet(string petName, string petType, byte age, string description);
        public Task<List<Pet>> AsyncGetAllPets();
        public Task AsyncDeletePet(long ID);
    }
}
