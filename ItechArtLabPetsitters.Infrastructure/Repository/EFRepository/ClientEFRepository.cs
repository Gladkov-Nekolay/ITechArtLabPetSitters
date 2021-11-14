using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class ClientEFRepository:IClientRepository
    {
        private readonly PetsittersContext _dbContext;
        public ClientEFRepository(PetsittersContext context) => this._dbContext = context;

        public async Task AsyncAddClient(string name, string phoneNumber)
        {
            _dbContext.Clients.Add(new Client(name, phoneNumber));
            await _dbContext.SaveChangesAsync();
        }

        public async Task AsyncDeleteClient(long ID)
        {
            Client deletedClient = await _dbContext.Clients.FirstAsync(p => p._ID == ID);
            _dbContext.Clients.Remove(deletedClient);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Client>> AsyncGetAllClients()
        {
            return await _dbContext.Clients.ToListAsync();
        }
    }
}

