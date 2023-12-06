using Assa.ApiResources.SeedData;
using Assa.Domain.Entities;
using Assa.Infrastructure.Data.Context;
using Assa.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAssaDbContext(builder.Configuration);

var app = builder.Build();

SeedData(app);

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void SeedData(WebApplication webApplication)
{
    using (var scope = webApplication.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<AssaDbContext>();
        db.Database.Migrate();
        db.SeedData(CarBrandSeedData.GetData(DateTime.Now));
    }

}