﻿namespace Entities.POCOEntities
{
    public class Orden_Detail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }

        public Orden Orden { get; set; }
    }
}
