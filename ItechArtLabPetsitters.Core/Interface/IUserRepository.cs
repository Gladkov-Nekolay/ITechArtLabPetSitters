using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Core.Interface
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsersAsync(PaginationSettingsModel paginationSettings);
    }
}
