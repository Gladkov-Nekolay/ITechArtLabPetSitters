using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ItechArtLabPetsitters.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class ServiceEFRepository : IServicesRepository
    {
        private readonly PetsittersContext _dbContext;
        private readonly IMapper mapper;
        public ServiceEFRepository(PetsittersContext context, IMapper Mapper) 
        { 
            this._dbContext = context;
            this.mapper = Mapper;
        }
        public async Task <List<Service>> GetAllServicesAsync()
        {
            return await _dbContext.Services.ToListAsync();
        }

        public async Task<Service> SearchServiceAsync(long ID)
        {
            return await _dbContext.Services.FirstAsync(p=>p.ID==ID);
        }
        public async Task AddServiceAsync(ServiceCreationModel model) 
        {
            Service AddedService = mapper.Map<ServiceCreationModel, Service>(model);
            _dbContext.Services.Add(AddedService);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteServiceAsync(long id) 
        {
            Service deletedService = await _dbContext.Services.FirstAsync(p => p.ID == id);
            if (deletedService != null) 
            {
                _dbContext.Services.Remove(deletedService);
                await _dbContext.SaveChangesAsync();
            }
            
        }
    }
}
