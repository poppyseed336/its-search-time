
using Microsoft.EntityFrameworkCore;
using SearchTimeBackEnd.Services;
using SearchTimeBackEnd.Models;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        policy => policy.WithOrigins("http://localhost:4200")  // Allow frontend to access API
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.WebHost.ConfigureKestrel(options =>
{
    options.Listen(IPAddress.Any, 5000);  // Listen on all network interfaces, not just localhost
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowLocalhost");
app.UseAuthorization();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate(); // Automatically apply any pending migrations and create the database if it doesn't exist
}

app.Run();
