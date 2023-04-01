using Cafelutza.Application.Services;
using Cafelutza.Data;
using Cafelutza.Data.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSpaStaticFiles(options =>
{
    options.RootPath = "../Cafelutza.SPA";
});
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRaportRepository, RaportRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRaportService, RaportService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(x=> x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAuthentication(GoogleDefaults.AuthenticationScheme).
    AddCookie().
    AddGoogle(options =>
{
    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.CallbackPath = "/sign-in";
    options.ClientId = builder.Configuration["Google:ClientId"];
    options.ClientSecret = builder.Configuration["Google:ClientSecret"];
    options.ClaimsIssuer = "Google";
    //options.Scope.Add("userinfo.email");
    //options.Scope.Add("userinfo.profile");
});
builder.Services.AddAuthorization();

builder.Services.AddCors(policy =>
{
    policy.AddPolicy("DefaultPolicy", options =>
    {
        options.AllowAnyHeader();
        options.AllowAnyMethod();
        options.AllowAnyOrigin();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    dbContext.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseCors("DefaultPolicy");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
