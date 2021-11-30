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
    public class ServiceProfile:Profile
    {
        public ServiceProfile() 
        {
            CreateMap<Service, ServiceCreationModel>().ForMember(u => u.Description, option => option.MapFrom(src => src.Description))
                                                      .ForMember(u => u.Price, option => option.MapFrom(src => src.Price))
                                                      .ForMember(u => u.ServiceName, option => option.MapFrom(src => src.ServiceName))
                                                      .ReverseMap();
        }
    }
}
