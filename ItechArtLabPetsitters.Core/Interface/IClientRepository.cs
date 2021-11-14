using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Core.Interface
{
    public interface IClientRepository
    {
        public Task AsyncAddClient(string name, string phoneNumber);
        public Task<List<Client>> AsyncGetAllClients();
        public Task AsyncDeleteClient(long ID);
    }
}
