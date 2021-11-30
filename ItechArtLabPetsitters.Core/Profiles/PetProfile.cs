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
    public class PetProfile:Profile
    {
        public PetProfile() 
        {
            CreateMap<Pet, PetCreationModel>().ForMember(u => u.PetName, option => option.MapFrom(src => src.PetName))
                                              .ForMember(u => u.PetType, option => option.MapFrom(src => src.PetType))
                                              .ForMember(u => u.Age, option => option.MapFrom(src => src.Age))
                                              .ForMember(u => u.OwnerID, option => option.MapFrom(src => src.OwnerID))
                                              .ForMember(u => u.Description, option => option.MapFrom(src => src.Description))
                                              .ReverseMap();
        }
    }
}
