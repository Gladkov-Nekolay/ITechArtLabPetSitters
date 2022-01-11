using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using ItechArtLabPetsitters.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

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
        public async Task <ActionResult> AddServiceAsync(ServiceCreationModel model) 
        {
            return await _ServiceRepository.AddServiceAsync(model);
        }
        public async Task <ActionResult> DeleteServiceAsync(long ID) 
        {
            return await _ServiceRepository.DeleteServiceAsync(ID);
        }

    }
}
