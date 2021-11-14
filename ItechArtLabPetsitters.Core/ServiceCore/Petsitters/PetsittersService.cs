using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.Interface;

namespace ItechArtLabPetsitters.Core.ServiceCore.Petsitters
{
    public class PetsittersService : IPetsittersService
    {
        private readonly IPetsittersRepository _PetsittersRepository;
        public PetsittersService(IPetsittersRepository PetsittersRepository)
        {
            _PetsittersRepository = PetsittersRepository;
        }
        public async Task AsyncAddPetsitter(string Name,string Number)
        {
            await _PetsittersRepository.AsyncAddPetsitter(Name,Number);
        }

        public async Task<List<Petsitter>> AsyncGetAllPetsitters()
        {
            return await _PetsittersRepository.AsyncGetAllPetsitters();
        }

        public async Task AsynkDeletePetsitter(long ID)
        {
            await _PetsittersRepository.AsyncDeletePetsitter(ID);
        }
    }
}
