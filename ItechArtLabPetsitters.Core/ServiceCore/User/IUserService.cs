using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public interface IUserService
    {
        public JwtSecurityToken GetNewToken(List <Claim> claims);//токены из клеймов
        public List<Claim> GetClaims(User user, IList<string> UserRoles);
        public Task <ActionResult> RegisterAsync(UserCreationModel model);
        public Task <IActionResult> LoginUserAsync(UserAuthentificationModel model);
        public Task<List<User>> GetAllUsersAsync(PaginationSettingsModel paginationSettings);
    }
}
