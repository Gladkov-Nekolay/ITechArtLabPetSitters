using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.ServiceCore;
using ItechArtLabPetsitters.Web.Interface;

namespace ItechArtLabPetsitters.Core.ServicesCore
{
    public class ServicesService : IServicesService
    {
        private readonly IServicesRepository _ServiceRepository;

        public ServicesService(IServicesRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
        }

        public List<Entities.Service> GetAllServices()
        {
            return _ServiceRepository.GetAllServices();
        }

        public Entities.Service Search(long ID)
        {
            return _ServiceRepository.Search(ID);
        }
    }
}
