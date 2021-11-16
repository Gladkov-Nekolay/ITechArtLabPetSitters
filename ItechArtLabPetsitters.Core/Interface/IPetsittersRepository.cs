using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IPetsittersRepository
    {
        public Task AddPetsitterAsync(string name, string phoneNumber);
        public Task<List<Petsitter>> GetAllPetsittersAsync();
        public Task DeletePetsitterAsync(long ID);
    }
}
