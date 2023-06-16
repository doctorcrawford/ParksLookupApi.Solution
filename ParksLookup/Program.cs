using ParksLookupApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ParksLookupApiContext>(
                  DbContextOptions => DbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        .AddEntityFrameworkStores<ParksLookupApiContext>()
        .AddDefaultTokenProviders();


builder.Services.AddAuthentication(options =>
                            {
                              options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                              options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                              options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                            })
                            .AddJwtBearer(options =>
                            {
                              options.SaveToken = true;
                              options.RequireHttpsMetadata = false;
                              options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                              {
                                ValidateIssuer = true,
                                ValidateAudience = true,
                                ValidAudience = configuration["JWT:ValidAudience"],
                                ValidIssuer = configuration["JWT:ValidIssuer"],
                                ClockSkew = TimeSpan.Zero,
                                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                              };
                            });


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
else
{
  app.UseHttpsRedirection();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
