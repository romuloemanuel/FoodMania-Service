
using FluentValidation;
using FoodMania.Application.Orders.Requests;

namespace FoodMania.Application.Orders.Validators
{
    public class MakeOrderRequestValidator : AbstractValidator<MakeOrderRequest>
    {
        public MakeOrderRequestValidator()
        {
            RuleFor(order => order.ClientId)
                .NotNull()
                .WithMessage("ClientId is required")
                .Must(order => !Guid.TryParse(order, out Guid guid))
                .WithMessage("ClientId is invalid");

            RuleFor(order => order.OrderProducts)
                .NotNull()
                .NotEmpty()
                .WithMessage("Order's Products is required");

            RuleFor(order => order.DeliveryAddress)
                .NotNull()
                .NotEmpty()
                .WithMessage("Delivery address is required");

        }
    }
}
