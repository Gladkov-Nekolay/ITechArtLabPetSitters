using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;

namespace ItechArtLabPetsitters.Repository.ServiceCore.Petsitters
{
    public class PetsittersService : IPetsittersService
    {
        private readonly IPetsittersRepository _PetsittersRepository;
        public PetsittersService(IPetsittersRepository PetsittersRepository)
        {
            _PetsittersRepository = PetsittersRepository;
        }
        public async Task AddPetsitterAsync(string Name,string Number)
        {
            await _PetsittersRepository.AddPetsitterAsync(Name,Number);
        }

        public async Task<List<Petsitter>> GetAllPetsittersAsync()
        {
            return await _PetsittersRepository.GetAllPetsittersAsync();
        }

        public async Task DeletePetsitterAsynk(long ID)
        {
            await _PetsittersRepository.DeletePetsitterAsync(ID);
        }
    }
}
