
using FoodMania.Infra.Extensions;
using FoodMania.Infra.IoC;
using FoodMania.Infra.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureDependencyInjection();
builder.Services.AddMasstransitConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware(typeof(ExceptionHandlingMiddleware));

app.MapControllers();

app.Run();
