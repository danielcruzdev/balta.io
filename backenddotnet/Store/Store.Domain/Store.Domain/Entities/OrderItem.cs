namespace Store.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, decimal price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public Product Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public decimal Total() => Price * Quantity;
    }
}
