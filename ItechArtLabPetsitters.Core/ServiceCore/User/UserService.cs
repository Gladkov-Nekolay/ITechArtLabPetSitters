using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task CreateUserAsync(UserCreationModel model)
        {
            await _UserRepository.CreateUserAsync(model);
        }

        public async Task DeleteUserAsync(long ID)
        {
            await _UserRepository.DeleteUserAsync(ID);
        }
        public async Task<List<User>> GetAllUsersAsync() 
        {
            return await _UserRepository.GetAllUsersAsync();
        }
    }
}
