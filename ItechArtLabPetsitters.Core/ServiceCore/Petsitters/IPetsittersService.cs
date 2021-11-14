using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Core.ServiceCore.Petsitters
{
    public interface IPetsittersService
    {
        public Task AsyncAddPetsitter(string Name,string Number);
        public Task AsynkDeletePetsitter(long ID);
        public Task<List<Petsitter>> AsyncGetAllPetsitters();
    }
}
