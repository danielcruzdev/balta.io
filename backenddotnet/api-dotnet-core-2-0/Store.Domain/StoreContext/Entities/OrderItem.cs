namespace Store.Domain.StoreContext.Entities
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
