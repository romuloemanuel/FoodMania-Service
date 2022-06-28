using FoodMania.Infra.Extensions;
using FoodMania.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddMasstransitConfiguration();

builder.Services.ConfigureDependencyInjection();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureVersioning();

builder.Services.AddSwaggerGen();
builder.Services.AddHeathCheckConfig();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerConfig();
}

app.UseHealthCheck();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
