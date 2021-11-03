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
        public List<Service> GetAllServices();
        public Service Search(long ID);
    }
}
