using FluentValidation.AspNetCore;
using FoodMania.Infra.Extensions;
using FoodMania.Infra.IoC;
using FoodMania.Infra.Middlewares;
using Serilog;
using Serilog.Formatting.Compact;

var builder = WebApplication.CreateBuilder(args);

builder.Host
    .UseSerilog((ctx, cfg) =>
    {
        cfg.Enrich.WithProperty("Application", ctx.HostingEnvironment.ApplicationName)
           .Enrich.WithProperty("Environment", ctx.HostingEnvironment.EnvironmentName)
           .WriteTo.Console(new RenderedCompactJsonFormatter());
    });


builder.Services.AddControllers();
builder.Services.ConfigureDependencyInjection();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureVersioning();
builder.Services.AddSwaggerGen();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddMasstransitConfiguration();
builder.Services.AddHeathCheckConfig();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerConfig();
}

app.UseHealthCheck();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware(typeof(ExceptionHandlingMiddleware));

app.MapControllers();

app.Run();
