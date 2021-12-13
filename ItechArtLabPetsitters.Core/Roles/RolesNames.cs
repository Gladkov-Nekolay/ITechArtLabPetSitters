using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ItechArtLabPetsitters.Core.Roles
{
    public class RolesNames
    {
        public const string USER = "User";
        public const string PETSITTER = "Petsitter";
        public const string ADMIN = "Admin";
        private static readonly List<IdentityRole<long>> RolesList = new List<IdentityRole<long>>()
        {
            new IdentityRole<long>(USER){ Id = 1, NormalizedName = "USER"},
            new IdentityRole<long>(PETSITTER){ Id = 2, NormalizedName = "PETSITTER"},
            new IdentityRole<long>(ADMIN){ Id = 3, NormalizedName = "ADMIN"}
        };
        public static List<IdentityRole<long>> ReturnRolesList() 
        {
            return RolesList;
        }
    }
}
