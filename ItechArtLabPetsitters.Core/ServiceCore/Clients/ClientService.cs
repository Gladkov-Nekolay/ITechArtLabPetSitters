using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;

namespace ItechArtLabPetsitters.Repository.ServiceCore.Clients
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
            await _ClientRepository.AddClientAsync(Name, Number);
        }

        public async Task<List<Client>> AsyncGetAllClients()
        {
            return await _ClientRepository.GetAllClientsAsync();
        }

        public async Task AsynkDeleteClient(long ID)
        {
            await _ClientRepository.DeleteClientAsync(ID);
        }
    }
}
