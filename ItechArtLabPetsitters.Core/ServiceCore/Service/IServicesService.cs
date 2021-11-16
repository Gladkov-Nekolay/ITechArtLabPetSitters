using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IServicesService
    {
        public Task <List<Service>> GetAllServicesAsync();
        public Task <Service> SearchServiceAsync(long ID);
        public Task AddServiceAsync(string name, string description, decimal price);
        public Task DeleteServiceAsync(long ID);
    }
}
