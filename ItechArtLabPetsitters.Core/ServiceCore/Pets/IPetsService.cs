using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Core.ServiceCore
{
    public interface IPetsService
    {
        public Task AsyncAddPet(string petName, string petType, byte age, string description);
        public Task AsynkDeletePet(long ID);
        public Task<List<Pet>> AsyncGetAllPets(); 
    }
}
