using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Web.Entities;
using ItechArtLabPetsitters.Web.Interface;

namespace ItechArtLabPetsitters.Web.Repository
{
    public class FakeRepository: IRepository
    {
        public List<Service> _Services { get; set; }
        public FakeRepository()
        {
            _Services = new List<Service>
            {
                new Service(ID: 1, ServiceName: "service name 1", Description: "Description 1"),
                new Service(ID: 2, ServiceName: "service name 2", Description: "Description 2")
            };
        }

        public List<Service> GetAllServices()
        {
            return _Services;
        }
    }
        
}
