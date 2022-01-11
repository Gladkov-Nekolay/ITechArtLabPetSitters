using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IServicesService
    {
        public Task <List<Service>> GetAllServicesAsync();
        public Task <Service> SearchServiceAsync(long ID);
        public Task <ActionResult> AddServiceAsync(ServiceCreationModel model);
        public Task <ActionResult> DeleteServiceAsync(long ID);
    }
}
