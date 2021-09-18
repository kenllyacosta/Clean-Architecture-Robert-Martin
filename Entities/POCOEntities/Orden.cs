using Entities.Enums;
using System;
using System.Collections.Generic;

namespace Entities.POCOEntities
{
    public class Orden
    {
        public int Id { get; set; }
        public int IdBusinessEntity { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string Country { get; set; }
        public string ShipPostalCode { get; set; }
        public DiscountType DiscountType { get; set; }
        public double Discount { get; set; }
        public ShippingType ShippingType { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public List<Orden_Detail> Orden_Details {  get; set; }
    }
}
