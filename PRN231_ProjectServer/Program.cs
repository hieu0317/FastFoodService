using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PRN231_ProjectMain.MapperProfile;
using PRN231_ProjectMain.Models;
using PRN231_ProjectMain.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddAutoMapper(typeof(MyMapper).Assembly);
builder.Services.AddDbContext<FinalProjectDbContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("MyCnn")));

builder.Services.AddIdentity<User, IdentityRole>(otps =>
{
    otps.Password.RequireLowercase = false;
    otps.Password.RequireNonAlphanumeric = false;
    otps.Password.RequireUppercase = false;
    otps.Password.RequiredLength = 6;
})
    .AddEntityFrameworkStores<FinalProjectDbContext>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(opts =>
    {
        opts.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<AuthenticateService>();
app.MapGrpcService<CartService>();
app.MapGrpcService<CategoryService>();
app.MapGrpcService<LikeService>();
app.MapGrpcService<ProductService>();
app.MapGrpcService<OrderService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.UseAuthentication();
app.UseAuthorization();

app.Run();
