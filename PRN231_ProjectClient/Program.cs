using Microsoft.AspNetCore.Authentication.Cookies;
using PRN231_ProjectClient;
using PRN231_ProjectClient.Services;
using PRN231_ProjectClient.Utils;
using PRN231_ProjectMain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<CartService>();
builder.Services.AddTransient<CategoryService>();
builder.Services.AddTransient<LikeService>();
builder.Services.AddTransient<ProductService>();
builder.Services.AddTransient<UserService>();
builder.Services.AddTransient<AuthInterceptor>();
builder.Services.AddTransient<AuthenticateService>();
builder.Services.AddTransient<OrderService>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddGrpcClient<Userer.UsererClient>(o =>
    o.Address = new Uri(builder.Configuration["Server:Url"])
).AddInterceptor(config => config.GetRequiredService<AuthInterceptor>());
builder.Services.AddGrpcClient<Carter.CarterClient>(o =>
    o.Address = new Uri(builder.Configuration["Server:Url"])
    ).AddInterceptor(config => config.GetRequiredService<AuthInterceptor>());
builder.Services.AddGrpcClient<Categorier.CategorierClient>(o =>
    o.Address = new Uri(builder.Configuration["Server:Url"])
    ).AddInterceptor(config => config.GetRequiredService<AuthInterceptor>());
builder.Services.AddGrpcClient<Liker.LikerClient>(o =>
    o.Address = new Uri(builder.Configuration["Server:Url"])
    ).AddInterceptor(config => config.GetRequiredService<AuthInterceptor>());
builder.Services.AddGrpcClient<Producter.ProducterClient>(o =>
    o.Address = new Uri(builder.Configuration["Server:Url"])
    ).AddInterceptor(config => config.GetRequiredService<AuthInterceptor>());
builder.Services.AddGrpcClient<Orderer.OrdererClient>(o =>
    o.Address = new Uri(builder.Configuration["Server:Url"])
    ).AddInterceptor(config => config.GetRequiredService<AuthInterceptor>());
builder.Services.AddGrpcClient<Authenticater.AuthenticaterClient>(o =>
    o.Address = new Uri(builder.Configuration["Server:Url"]));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Authenticate/Login";
                    options.AccessDeniedPath = "/Index";
                });
builder.Services.AddAuthorization();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
