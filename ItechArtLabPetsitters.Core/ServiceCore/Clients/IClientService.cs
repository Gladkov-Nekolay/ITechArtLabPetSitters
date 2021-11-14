using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Core.ServiceCore.Clients
{
    public interface IClientService
    {
        public Task AsyncAddClient(string Name, string Number);
        public Task AsynkDeleteClient(long ID);
        public Task<List<Client>> AsyncGetAllClients();
    }
}
