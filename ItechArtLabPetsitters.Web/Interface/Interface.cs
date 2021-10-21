using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Web.Entities;

namespace ItechArtLabPetsitters.Web.Interface
{
    interface IRepository
    {
        public List<Service> GetAllServices();


    }
}
