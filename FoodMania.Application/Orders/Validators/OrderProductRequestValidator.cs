using FluentValidation;
using FoodMania.Application.Orders.Requests;

namespace FoodMania.Application.Orders.Validators
{
    public class OrderProductRequestValidator : AbstractValidator<OrderProductRequest>
    {
        public OrderProductRequestValidator()
        {
            RuleFor(order => order.Id)
              .NotNull()
              .NotEmpty()
              .WithMessage("Id of product is required")
              .Must(order => !Guid.TryParse(order, out Guid guid))
              .WithMessage("Id of product is invalid");

            RuleFor(order => order.Quantity)
               .Must(order => order > 1)
               .WithMessage("Quantity must be bigger than 0");
        }
    }
}
