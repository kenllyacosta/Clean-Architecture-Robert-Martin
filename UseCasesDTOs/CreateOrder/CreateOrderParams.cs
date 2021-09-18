using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
