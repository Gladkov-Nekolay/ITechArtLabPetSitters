using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public class ServicesService : IServicesService
    {
        private readonly IServicesRepository _ServiceRepository;

        public ServicesService(IServicesRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
        }

        public async Task<List<Service>> GetAllServicesAsync()
        {
            return await _ServiceRepository.GetAllServicesAsync();
        }

        public async Task<Service> SearchServiceAsync(long ID)
        {
            return await _ServiceRepository.SearchServiceAsync(ID);
        }
        public async Task AddServiceAsync(ServiceCreationModel model) 
        {
            await _ServiceRepository.AddServiceAsync(model);
        }
        public async Task DeleteServiceAsync(long ID) 
        {
            await _ServiceRepository.DeleteServiceAsync(ID);
        }

    }
}
