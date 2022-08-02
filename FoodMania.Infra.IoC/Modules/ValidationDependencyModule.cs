using FluentValidation;
using FoodMania.Application.Orders.Requests;
using FoodMania.Application.Orders.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace FoodMania.Infra.IoC.Modules
{
    public static class ValidationDependencyModule
    {
        public static void ConfigureValidationDependency(this IServiceCollection services)
        {
            services.AddScoped<IValidator<MakeOrderRequest>, MakeOrderRequestValidator>();
        }
    }
}
