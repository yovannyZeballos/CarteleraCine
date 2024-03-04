using CarteleriaCine.Business;
using CarteleriaCine.Business.Impl;
using CarteleriaCine.Repository;
using Microsoft.EntityFrameworkCore;

var Origins = "_origins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: Origins,
					  policy =>
					  {
						  policy.WithOrigins("http://localhost:4200")
						  .AllowAnyHeader()
						  .AllowAnyMethod();
					  });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CarteleriaContexto>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("CarteleriaDatabase")));

builder.Services.AddScoped<IPeliculaService, PeliculaServicesImpl>();
builder.Services.AddScoped<IReservaService, ReservaServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(Origins);

app.UseAuthorization();

app.MapControllers();

app.Run();
