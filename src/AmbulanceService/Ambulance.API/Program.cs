using Ambulance.Infrastructure;
using Ambulance.Application;
using Microsoft.EntityFrameworkCore;


using Ambulance.Infrastructure.Persistance;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddInfrastructures(builder.Configuration);
builder.Services.AddAplications();

builder.Services.AddControllers();
builder.Services.AddDbContext<AmbulanceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
