using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.ServiceCore;
using ItechArtLabPetsitters.Core.Interface;

namespace ItechArtLabPetsitters.Core.ServicesCore
{
    public class ServicesService : IServicesService
    {
        private readonly IServicesRepository _ServiceRepository;

        public ServicesService(IServicesRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
        }

        public async Task<List<Entities.Service>> AsyncGetAllServices()
        {
            return await _ServiceRepository.AsyncGetAllServices();
        }

        public async Task<Entities.Service> AsyncSearchService(long ID)
        {
            return await _ServiceRepository.AsyncSearchService(ID);
        }
        public async Task AsyncAddService(string name, string description, decimal price) 
        {
            await _ServiceRepository.AsyncAddService(name, description, price);
        }
        public async Task AsyncDeleteService(long ID) 
        {
            await _ServiceRepository.AsyncDeleteService(ID);
        }

    }
}
