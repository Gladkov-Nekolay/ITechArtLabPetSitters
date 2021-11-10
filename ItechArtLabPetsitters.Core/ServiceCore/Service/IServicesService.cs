using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Core.ServiceCore
{
    public interface IServicesService
    {
        public Task <List<Service>> AsyncGetAllServices();
        public Task <Service> AsyncSearchService(long ID);
        public Task AsyncAddService(string name, string description, decimal price);
        public Task AsyncDeleteService(long ID);
    }
}
