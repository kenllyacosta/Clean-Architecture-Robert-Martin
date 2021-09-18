using Entities.Exceptions;
using Entities.Interfaces;
using Entities.POCOEntities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UseCases.CreateOrder
{
    public class CreateOrderInteractor : IRequestHandler<CreateOrderInputPort, int>
    {
        readonly IOrderRepository OrderRepository;
        readonly IOrderDetailRepository OrderDetailRepository;
        readonly IUnitOfWork UnitOfWork;

        public CreateOrderInteractor(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, IUnitOfWork unitOfWork)
        {
            OrderRepository = orderRepository;
            OrderDetailRepository = orderDetailRepository;
            UnitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateOrderInputPort request, CancellationToken cancellationToken)
        {
            Orden orden = new Orden() 
            {
                IdBusinessEntity = request.BusinessEntityId,
                Country= request.ShipContry,
                ShipPostalCode= request.ShipPostalCode,
                ShipAddress= request.ShipAddress,
                OrderDate = DateTime.Now,
                ShipCity= request.ShipCity,
                ShippingType = Entities.Enums.ShippingType.Road,
                DiscountType = Entities.Enums.DiscountType.Percentage,
                Discount = 10,
            };

            foreach (var item in request.OrderDetail)
                orden.Orden_Details.Add(new Orden_Detail() { ProductId = item.ProductId, UnitPrice = item.UnitPrice, Quantity =item.Quantity });

            OrderRepository.Create(orden);

            try
            {
                await UnitOfWork.SavechangesAsync();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al crear la orden", ex.Message);
            }

            return orden.Id;
        }
    }
}
