using System.Collections.Generic;

namespace UseCasesDTOs.CreateOrder
{
    public class CreateOrderParams
    {
        public int BusinessEntityId { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipContry { get; set; }
        public string ShipPostalCode { get; set; }
        public List<CreateOrderdetailParams> OrderDetail { get; set; }
    }
}
