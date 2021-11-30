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
    public class OrderProfile:Profile
    {
        public OrderProfile() 
        {
            CreateMap<Order, OrderCreationModel>().ForMember(u => u.clientID, option => option.MapFrom(src => src.ClientID))
                                               .ForMember(u => u.comment, option => option.MapFrom(src => src.Comment))
                                               .ForMember(u => u.petID, option => option.MapFrom(src => src.PetID))
                                               .ForMember(u=> u.serviceID,option=>option.MapFrom(src=>src.ServiceID))
                                               .ReverseMap();
        }

    }
}
