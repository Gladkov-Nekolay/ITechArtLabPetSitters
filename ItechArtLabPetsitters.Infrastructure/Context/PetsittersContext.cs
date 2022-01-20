using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Roles;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ItechArtLabPetsitters.Infrastructure.Context
{
    public class PetsittersContext : IdentityDbContext<User, IdentityRole<long>, long>
    {
        public PetsittersContext(DbContextOptions<PetsittersContext> options) : base(options) // пересоздвавать миграцию ?
        {
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<IdentityRole<long>> identityRoles = RolesNames.ReturnRolesList();
            builder.Entity<IdentityRole<long>>().HasData(identityRoles);
        }
    }
}