﻿using Infrastructure.Utilities.Security.JWT;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;

namespace Banka.WebApi
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApiService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().
                AddJsonOptions(opt => opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            //------------------------------------------------
            // Aşağıda [Authorize] atribute'unun bir jwt token doğrulaması yapması gerektiği tanımlanmıştır : 
            //------------------------------------------------
            var tokenoptions = configuration.GetSection("Tokenoptions").Get<Tokenoptions>();

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = tokenoptions.Issuer,
                    ValidAudience = tokenoptions.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenoptions.SecurityKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });

            //------------------------------------------------


            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "JWT Auhorization",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
        {
          {
            new OpenApiSecurityScheme
            {
              Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id="Bearer"
              }
            },
            new List<string>()
          }
        });
            });
        }
    }
}
