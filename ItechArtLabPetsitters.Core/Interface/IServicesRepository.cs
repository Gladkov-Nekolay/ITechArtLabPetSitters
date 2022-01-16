using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IServicesRepository
    {
        public Task<List<Service>> GetAllServicesAsync();
        public Task<Service> SearchServiceAsync(long ID);
        public Task AddServiceAsync(ServiceCreationModel model);
        public Task DeleteServiceAsync(long ID);
    }
}
