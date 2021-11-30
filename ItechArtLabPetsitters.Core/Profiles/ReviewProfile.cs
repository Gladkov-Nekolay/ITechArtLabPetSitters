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
    public class ReviewProfile:Profile
    {
       public ReviewProfile() 
        {
            CreateMap<Review,ReviewCreationModel>().ForMember(u => u.ClientID, option => option.MapFrom(src => src.ClientID))
                                              .ForMember(u => u.Comment, option => option.MapFrom(src => src.Comment))
                                              .ForMember(u => u.Mark, option => option.MapFrom(src => src.Mark))
                                              .ForMember(u => u.PetsitterID, option => option.MapFrom(src => src.PetsitterID))
                                              .ReverseMap();

        }
    }
}
