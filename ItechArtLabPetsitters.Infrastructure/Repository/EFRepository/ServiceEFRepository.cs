using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Web.Interface;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class ServiceEFRepository : IServicesRepository
    {
        private readonly PetsittersContext _dbContext;
        public ServiceEFRepository(PetsittersContext context) => this._dbContext = context;

        public void AddService(Service service)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetAllServices()
        {
            return _dbContext.Services.ToList();
        }

        public Service Search(long ID)
        {
            return _dbContext.Services.Find(ID);
        }
    }
}
