using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ItechArtLabPetsitters.Repository.ServiceCore;
using ItechArtLabPetsitters.Infrastructure.Repository.EFRepository;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Repository.Interface;
using ItechArtLabPetsitters.Repository.ServiceCore.Reviews;
using Microsoft.EntityFrameworkCore;
using ItechArtLabPetsitters.Core.Interface;
using ItechArtLabPetsitters.Core.ServiceCore.Order;
using ItechArtLabPetsitters.Core.Profiles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ItechArtLabPetsitters.Core.JWTSettings;
using Microsoft.AspNetCore.Identity;

namespace ItechArtLabPetsitters.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // domain
            services.AddScoped<IServicesService, ServicesService>();// 1 экземпляр на 1 запрос 
            services.AddScoped<IPetsService, PetsService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrdersService, OrderService>();
            // infrastructure
            services.AddScoped<IServicesRepository, ServiceEFRepository>();
            services.AddScoped<IPetsRepository, PetsEFRepository>();
            services.AddScoped<IReviewRepository, RewiewEFRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderEFRepository>();

            //automapping
            services.AddAutoMapper(
               typeof(UserProfile),
               typeof(OrderProfile),
               typeof(ServiceProfile),
               typeof(PetProfile),
               typeof(ReviewProfile)
               );

            services.AddIdentity<User, IdentityRole<long>>(options => {
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<PetsittersContext>();

            services.AddDbContext<PetsittersContext>(context => context.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            // Adding Authentication  
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            // Adding Jwt Bearer  
            .AddJwtBearer(options =>
             {
                 options.SaveToken = true;
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,

                     ValidIssuer = JWTSettings.ValidIssuer,
                     ValidAudience = JWTSettings.ValidAudience,
                     IssuerSigningKey = JWTSettings.GetSecretKey()
                 };
             });




            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ItechArtLabPetsitters.Web", Version = "v1" });
                c.AddSecurityDefinition("Bearer",
                    new OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "Bearer",
                        BearerFormat = "JWT",
                        In = ParameterLocation.Header,
                        Description = @"JWT Authorization header using the Bearer scheme.
                                        Enter 'Bearer' [space] and then you token in the text input below.
                                        Example: 'Bearer SsASdjjklxxuSAD'",


                    });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ItechArtLabPetsitters.Web v1"));
            }
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}