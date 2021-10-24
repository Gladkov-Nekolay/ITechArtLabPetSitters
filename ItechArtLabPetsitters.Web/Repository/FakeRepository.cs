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
        private static List<Service> _Services = new List<Service>
            {
                new Service(ID: 0, ServiceName: "service name 0", Description: "Description 0"),
                new Service(ID: 1, ServiceName: "service name 1", Description: "Description 1")
            };

        public List<Service> GetAllServices() // return list of all services
        {
            return _Services;
        }
        public Service Search(long ID)  // searching searvice by ID
        {
            Service resoult = (from service in _Services
                               where service._ID == ID
                               select service).FirstOrDefault();
            return resoult;
             
        }
        public void AddService(string Name, string Description) 
        {
            _Services.Add(new Service(ID: (long)_Services.Count, Name, Description));
        }
    }
}
