using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class ServiceEFRepository : IServicesRepository
    {
        private readonly PetsittersContext _dbContext;
        public ServiceEFRepository(PetsittersContext context) => this._dbContext = context;
        public async Task <List<Service>> GetAllServicesAsync()
        {
            return await _dbContext.Services.ToListAsync();
        }

        public async Task<Service> SearchServiceAsync(long ID)
        {
            return await _dbContext.Services.FirstAsync(p=>p.ID==ID);
        }
        public async Task AddServiceAsync(string name, string description, double price) 
        {
            _dbContext.Services.Add(new Service(name, description, price));
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteServiceAsync(long id) 
        {
            Service deletedService = await _dbContext.Services.FirstAsync(p => p.ID == id); 
            _dbContext.Services.Remove(deletedService);
            await _dbContext.SaveChangesAsync();
        }
    }
}
