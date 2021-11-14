using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.Interface;

namespace ItechArtLabPetsitters.Core.ServiceCore.Clients
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _ClientRepository;
        public ClientService(IClientRepository ClientRepository)
        {
            _ClientRepository = ClientRepository;
        }
        public async Task AsyncAddClient(string Name, string Number)
        {
            await _ClientRepository.AsyncAddClient(Name, Number);
        }

        public async Task<List<Client>> AsyncGetAllClients()
        {
            return await _ClientRepository.AsyncGetAllClients();
        }

        public async Task AsynkDeleteClient(long ID)
        {
            await _ClientRepository.AsyncDeleteClient(ID);
        }
    }
}
