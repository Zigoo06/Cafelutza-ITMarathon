using Cafelutza.Application.Services;
using Cafelutza.Data;
using Cafelutza.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRaportRepository, RaportRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRaportService, RaportService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(x=> x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
app.UseAuthorization();

app.MapControllers();

app.Run();
