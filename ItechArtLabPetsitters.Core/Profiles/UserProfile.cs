using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Core.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<User, UserCreationModel>()
                .ForMember(u => u.Name, option => option.MapFrom(src=>src.UserName))
                .ReverseMap();
        }
    }
}
