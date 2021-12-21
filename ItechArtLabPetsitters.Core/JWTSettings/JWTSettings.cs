using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace ItechArtLabPetsitters.Core.JWTSettings
{
    public class JWTSettings
    {
        public const string ValidIssuer = "Server";
        public const string ValidAudience = "Client";
        public const int TokenLifeTime = 60; // minutes
        public const string SecretKey = "SecSecSecretKeyretKeyreSecretKeytKey";
        public static SymmetricSecurityKey GetSecretKey() 
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
        }
    }
}
