using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IPetsService
    {
        public Task<ActionResult> AddPetAsync(PetCreationModel model);
        public Task<ActionResult> DeletePetAsync(long ID);
        public Task<List<Pet>> GetUserPetsAsync(long userID); 
    }
}
