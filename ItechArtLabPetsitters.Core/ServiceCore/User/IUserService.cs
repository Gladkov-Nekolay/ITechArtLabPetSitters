using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IUserService
    {
        public Task CreateUserAsync(UserModel model);
        public Task DeleteUserAsync(long ID);
        public Task<List<User>> GetAllUsersAsync();
    }
}
