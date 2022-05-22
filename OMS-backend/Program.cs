using DomainServices;
using Infrastructure.Service.Contract_interface;
using Infrastructure.Service.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(Options => Options.UseNpgsql(connectionString));
builder.Services.AddScoped<IUloga, ImplUloga>();
builder.Services.AddScoped<ITim, ImplTim>();
builder.Services.AddScoped<IStatusopreme, ImplStatusopreme>();
builder.Services.AddScoped<IPozicija, ImplPozicija>();
builder.Services.AddScoped<IOprema, ImplOprema>();
builder.Services.AddScoped<IOsoba, ImplOsoba>();
builder.Services.AddScoped<IKategorijaopreme, ImplKategorijaopreme>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
