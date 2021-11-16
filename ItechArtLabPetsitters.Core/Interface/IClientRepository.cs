using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IClientRepository
    {
        public Task AddClientAsync(string name, string phoneNumber);
        public Task<List<Client>> GetAllClientsAsync();
        public Task DeleteClientAsync(long ID);
    }
}
