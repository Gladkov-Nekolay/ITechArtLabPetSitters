using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Interface;

namespace ItechArtLabPetsitters.Core.ServiceCore
{
    public class PetsService : IPetsService
    {
        private readonly IPetsRepository _PetsRepository;
        public PetsService (IPetsRepository PetsRepository)
        {
            _PetsRepository = PetsRepository;
        }
        public async Task AsyncAddPet(string petName, string petType, byte age, string description)
        {
             await _PetsRepository.AsyncAddPet(petName, petType, age, description);
        }

        public async Task AsynkDeletePet(long ID)
        {
            await _PetsRepository.AsyncDeletePet(ID);
        }
        public async Task<List<Entities.Pet>> AsyncGetAllPets()
        {
            return await _PetsRepository.AsyncGetAllPets();
        }
    }
}
