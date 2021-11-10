using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Web.Interface;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class ServiceEFRepository : IServicesRepository
    {
        private readonly PetsittersContext _dbContext;
        public ServiceEFRepository(PetsittersContext context) => this._dbContext = context;
        public async Task <List<Service>> AsyncGetAllServices()
        {
            return await _dbContext.Services.ToListAsync();
        }

        public async Task<Service> AsyncSearchService(long ID)
        {
            return await _dbContext.Services.FirstAsync(p=>p._ID==ID);
        }
        public async Task AsyncAddService(string name, string description, decimal price) 
        {
            _dbContext.Services.Add(new Service(name, description, price));
            await _dbContext.SaveChangesAsync();
        }
        public async Task AsyncDeleteService(long id) 
        {
            Service deletedService = await _dbContext.Services.FirstAsync(p => p._ID == id); ;
            _dbContext.Services.Remove(deletedService);
            await _dbContext.SaveChangesAsync();
        }
    }
}
