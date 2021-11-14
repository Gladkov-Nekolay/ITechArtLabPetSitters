using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Core.Interface
{
    public interface IPetsittersRepository
    {
        public Task AsyncAddPetsitter(string name, string phoneNumber);
        public Task<List<Petsitter>> AsyncGetAllPetsitters();
        public Task AsyncDeletePetsitter(long ID);
    }
}
