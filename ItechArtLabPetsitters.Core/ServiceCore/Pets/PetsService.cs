using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public class PetsService : IPetsService
    {
        private readonly IPetsRepository _PetsRepository;
        public PetsService (IPetsRepository PetsRepository)
        {
            _PetsRepository = PetsRepository;
        }
        public async Task<ActionResult> AddPetAsync(PetCreationModel model)
        {
             return await _PetsRepository.AddPetAsync(model);
        }

        public async Task<ActionResult> DeletePetAsync(long ID)
        {
            return await _PetsRepository.DeletePetAsync(ID);
        }
        public async Task<List<Pet>> GetAllPetsAsync()
        {
            return await _PetsRepository.GetAllPetsAsync();
        }
    }
}
