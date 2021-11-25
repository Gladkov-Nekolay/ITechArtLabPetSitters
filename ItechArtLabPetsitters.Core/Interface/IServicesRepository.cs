using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Interface
{
    public interface IServicesRepository
    {
        public Task<List<Service>> GetAllServicesAsync();
        public Task<Service> SearchServiceAsync(long ID);
        public Task AddServiceAsync(string name, string description, double price);
        public Task DeleteServiceAsync(long ID);
    }
}
