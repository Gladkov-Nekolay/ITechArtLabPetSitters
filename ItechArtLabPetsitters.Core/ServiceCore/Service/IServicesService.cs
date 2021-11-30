using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IServicesService
    {
        public Task <List<Service>> GetAllServicesAsync();
        public Task <Service> SearchServiceAsync(long ID);
        public Task AddServiceAsync(ServiceCreationModel model);
        public Task DeleteServiceAsync(long ID);
    }
}
