using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;

namespace ItechArtLabPetsitters.Web.Interface
{
    public interface IRepository
    {
        public List<Service> GetAllServices();
        public Service Search(long ID);


    }
}
