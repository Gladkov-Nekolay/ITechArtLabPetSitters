﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class UserRepository:IUserRepository
    {
        private readonly PetsittersContext _dbContext;
        private readonly IMapper mapper;
        public UserRepository(PetsittersContext context,IMapper Mapper)
        {
            this._dbContext = context;
            this.mapper = Mapper;
        }
        public async Task<List<User>> GetAllUsersAsync() 
        {
            return await _dbContext.Users.ToListAsync();
        }

    }
}