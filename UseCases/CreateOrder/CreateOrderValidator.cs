using FluentValidation;
using System.Linq;

namespace UseCases.CreateOrder
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderInputPort>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.BusinessEntityId).NotEmpty().WithMessage("debe proporcionar el cliente");
            RuleFor(x => x.ShipAddress).NotEmpty().WithMessage("Debes proporcionar dirección de envio");
            RuleFor(x => x.ShipCity).NotEmpty().MinimumLength(3).WithMessage("Debes proporcionar la ciudad");
            RuleFor(x => x.ShipContry).NotEmpty().MinimumLength(3).WithMessage("Debes proporcionar la ciudad");
            RuleFor(x => x.OrderDetail).Must(x => x != null && x.Any()).WithMessage("Debes especificar productos");
        }
    }
}
