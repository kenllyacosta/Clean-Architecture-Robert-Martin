using MediatR;
using UseCasesDTOs.CreateOrder;

namespace UseCases.CreateOrder
{
    public class CreateOrderInputPort : CreateOrderParams, IRequest<int>
    {

    }
}
