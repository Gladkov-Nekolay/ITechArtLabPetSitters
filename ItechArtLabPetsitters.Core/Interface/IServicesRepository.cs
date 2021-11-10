using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Web.Interface
{
    public interface IServicesRepository
    {
        public Task<List<Service>> AsyncGetAllServices();
        public Task<Service> AsyncSearchService(long ID);
        public Task AsyncAddService(string name, string description, decimal price);
        public Task AsyncDeleteService(long ID);
    }
}
