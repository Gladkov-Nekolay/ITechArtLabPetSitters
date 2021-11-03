using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Web.Interface
{
    public interface IServicesRepository
    {
        public List<Service> GetAllServices();
        public Service Search(long ID);
        public void AddService(Service service);


    }
}
