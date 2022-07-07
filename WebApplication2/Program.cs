using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<PlayerContext>(opt => {
    opt.UseInMemoryDatabase("PlayerList");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
