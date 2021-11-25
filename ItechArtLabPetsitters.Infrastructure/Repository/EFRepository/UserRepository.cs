using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class UserRepository:IUserRepository
    {
        public readonly PetsittersContext _dbContext;
        public UserRepository(PetsittersContext context) => this._dbContext = context;

        public async Task CreateUserAsync(UserModel model)
        {
            _dbContext.Users.Add
                (new User{
                    Email = model.Email,
                    Name = model.Name}
                );
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteUserAsync(long ID)
        {
            User DeletedUser = await _dbContext.Users.FirstAsync(p => p.ID == ID);
            _dbContext.Users.Remove(DeletedUser);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<User>> GetAllUsersAsync() 
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}