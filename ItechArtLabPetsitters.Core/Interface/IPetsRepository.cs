using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IPetsRepository
    {
        public Task <ActionResult> AddPetAsync(PetCreationModel model);
        public Task<List<Pet>> GetAllPetsAsync();
        public Task <ActionResult> DeletePetAsync(long ID);
    }
}
