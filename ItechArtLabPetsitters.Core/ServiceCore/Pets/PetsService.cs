using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public class PetsService : IPetsService
    {
        private readonly IPetsRepository _PetsRepository;
        public PetsService (IPetsRepository PetsRepository)
        {
            _PetsRepository = PetsRepository;
        }
        public async Task AddPetAsync(string petName, string petType, byte age, string description)
        {
             await _PetsRepository.AddPetAsync(petName, petType, age, description);
        }

        public async Task DeletePetAsync(long ID)
        {
            await _PetsRepository.DeletePetAsync(ID);
        }
        public async Task<List<Pet>> GetAllPetsAsync()
        {
            return await _PetsRepository.GetAllPetsAsync();
        }
    }
}
