using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using AutoMapper;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Core.Profiles;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Infrastructure.Repository.EFRepository;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Xunit;

namespace Tests
{
    public partial class OrderRepositoryTest
    {
        [Fact]
        public void GetAvaliablePagedOrderTest()
        {
            //Arrage
            var options = new DbContextOptionsBuilder<PetsittersContext>()
            .UseInMemoryDatabase(databaseName: "OrderAvaluableListDatabase")
            .Options;
            using (var ContextAvaluableOrders = new PetsittersContext(options)) 
            {
                ContextAvaluableOrders.Orders.Add(new Order { ID = 1, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextAvaluableOrders.Orders.Add(new Order { ID = 2, PetsitterID = null, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextAvaluableOrders.Orders.Add(new Order { ID = 3, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextAvaluableOrders.SaveChanges();
            }
            // pagination
            PaginationSettingsModel paginationSettings = new PaginationSettingsModel();
            paginationSettings.PageNumber = 1;
            paginationSettings.PageSize = 5;
            
            using (var Context = new PetsittersContext(options))
            {
                var OrderRepository = new OrderEFRepository(Context);
                //Act
                var ResultAvalubleOrders = OrderRepository.GetAvaliableOrderListAsync(paginationSettings).Result;
                //Assert
                List<Order> ExpectedAvaluableOrders = new List<Order>
                {
                    new Order {ID = 2, PetsitterID = null, ClientID = 1, PetID = 1, ServiceID = 1}
                };
                bool AssertResult = true;
                if (ExpectedAvaluableOrders.Count() == ResultAvalubleOrders.Count()) {
                    for (int i = 0; i < ExpectedAvaluableOrders.Count(); i++) 
                    {
                        if (ResultAvalubleOrders[i].ID != ExpectedAvaluableOrders[i].ID) 
                        {
                            AssertResult = false;
                            break;
                        }
                    };

                }
                else 
                {
                    AssertResult = false;
                }
                Assert.True(AssertResult);
            }
        }
        [Fact]
        public void GetPagedOrdersTest()
        {
            var options = new DbContextOptionsBuilder<PetsittersContext>()
            .UseInMemoryDatabase(databaseName: "OrderAllListDatabase")
            .Options;
            using (var ContextPagedAll = new PetsittersContext(options))
            {
                ContextPagedAll.Orders.Add(new Order { ID = 1, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextPagedAll.Orders.Add(new Order { ID = 2, PetsitterID = null, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextPagedAll.Orders.Add(new Order { ID = 3, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextPagedAll.Orders.Add(new Order { ID = 4, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextPagedAll.Orders.Add(new Order { ID = 5, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextPagedAll.Orders.Add(new Order { ID = 6, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 });
                ContextPagedAll.SaveChanges();
            }
            // pagination
            PaginationSettingsModel paginationSettings = new PaginationSettingsModel();
            paginationSettings.PageNumber = 1;
            paginationSettings.PageSize = 4;

            using (var ContextTest2 = new PetsittersContext(options))
            {
                var OrderRepository = new OrderEFRepository(ContextTest2);
                //Act
                var ResultAvalubleOrders = OrderRepository.GetAllOrdersListAsync(paginationSettings).Result;
                //Assert
                List<Order> ExpectedAvaluableOrders = new List<Order>
                {
                    new Order { ID = 1, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 },
                    new Order { ID = 2, PetsitterID = null, ClientID = 1, PetID = 1, ServiceID = 1},
                    new Order { ID = 3, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 },
                    new Order { ID = 4, PetsitterID = 1, ClientID = 1, PetID = 1, ServiceID = 1 }
                };
                bool AssertResult = true;
                if (ExpectedAvaluableOrders.Count() == ResultAvalubleOrders.Count())
                {
                    for (int i = 0; i < ExpectedAvaluableOrders.Count(); i++)
                    {
                        if (ResultAvalubleOrders[i].ID != ExpectedAvaluableOrders[i].ID)
                        {
                            AssertResult = false;
                            break;
                        }
                    };

                }
                else
                {
                    AssertResult = false;
                }
                Assert.True(AssertResult);
            }
        }
    }
}
