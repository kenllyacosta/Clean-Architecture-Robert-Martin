namespace UseCasesDTOs.CreateOrder
{
    public class CreateOrderdetailParams
    {
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
