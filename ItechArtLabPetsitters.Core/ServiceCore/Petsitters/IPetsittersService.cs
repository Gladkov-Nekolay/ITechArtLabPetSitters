using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.ServiceCore.Petsitters
{
    public interface IPetsittersService
    {
        public Task AddPetsitterAsync(string Name,string Number);
        public Task DeletePetsitterAsynk(long ID);
        public Task<List<Petsitter>> GetAllPetsittersAsync();
    }
}
