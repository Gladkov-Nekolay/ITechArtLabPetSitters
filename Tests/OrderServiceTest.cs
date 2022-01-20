using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Core.Profiles;
using ItechArtLabPetsitters.Repository.Entities;
using Moq;
using Xunit;

namespace Tests
{
    public partial class OrderServiceTest
    {
        [Fact]
        public void CreateOrderMappingTest() 
        {
            //Arrage
            OrderCreationModel CreationModel = new OrderCreationModel {clientID=1, serviceID=1, petID=1, comment="Comment" };
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new OrderProfile());
            });
            var mapper = mockMapper.CreateMapper();
            Order ExpectedResult = new Order { ClientID = 1, ServiceID = 1, PetID = 1, Comment = "Comment" };
            //Act
            Order ActualResult = mapper.Map<OrderCreationModel, Order>(CreationModel);
            //Assert
            Assert.True(ActualResult.ClientID==ExpectedResult.ClientID&&
                        ActualResult.ServiceID==ExpectedResult.ServiceID&&
                        ActualResult.PetID==ExpectedResult.PetID&&
                        ActualResult.Comment.Equals(ExpectedResult.Comment));
        }
    }
}
