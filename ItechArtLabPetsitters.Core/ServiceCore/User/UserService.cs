using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.JWTSettings;
using ItechArtLabPetsitters.Core.Models;
using ItechArtLabPetsitters.Core.Roles;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ItechArtLabPetsitters.Repository.ServiceCore
{
    public class UserService:IUserService
    {
        private readonly UserManager<User> _UserManager;
        private readonly IUserRepository _UserRepository;
        private readonly IMapper mapper;
        public UserService(IUserRepository userRepository,UserManager<User> userManager,IMapper Mapper)
        {
            _UserRepository = userRepository;
            _UserManager = userManager;
            mapper = Mapper;
        }

        public async Task <ActionResult> RegisterAsync(UserCreationModel model)
        {
            User user = mapper.Map<UserCreationModel, User>(model);
            var result = await _UserManager.CreateAsync(user,model.Password);
            await _UserManager.AddToRoleAsync(user, RolesNames.USER);
            return new OkResult();
        }

        public async Task<List<User>> GetAllUsersAsync(PaginationSettingsModel paginationSettings) 
        {
            return await _UserRepository.GetAllUsersAsync(paginationSettings);
        }

        public async Task<IActionResult> LoginUserAsync(UserAuthentificationModel model)
        {
            User user = await _UserManager.FindByEmailAsync(model.Email.Normalize());
            if (user == null) 
            {
                return new NotFoundObjectResult($"User with email '{model.Email}' was not found.");
            }

            if (await _UserManager.CheckPasswordAsync(user, model.Password))
            {
                // вернуть JWT
                var UserRoles = await _UserManager.GetRolesAsync(user);
                var Claims = GetClaims(user, UserRoles);
                var JwtToken = GetNewToken(Claims);
                return new OkObjectResult(new
                {
                    claims = Claims,
                    roles = UserRoles,
                    token = new JwtSecurityTokenHandler()
                    .WriteToken(JwtToken),
                    expiration = JwtToken.ValidTo,
                    id = user.Id
                });
            }
            else 
            {
                //ошибка пароля
                return new UnauthorizedObjectResult("Invalid password.");
            }
            
        }

        public JwtSecurityToken GetNewToken(List<Claim> Claims)
        {
            return new JwtSecurityToken(issuer: JWTSettings.ValidIssuer,
                audience: JWTSettings.ValidAudience,
                notBefore: DateTime.UtcNow,
                claims: Claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(JWTSettings.TokenLifeTime)),
                signingCredentials: new SigningCredentials(JWTSettings.GetSecretKey(), SecurityAlgorithms.HmacSha256)
                );
        }

        public List<Claim> GetClaims(User user, IList<string> UserRoles)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };
            foreach (string role in UserRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
    }
}
