using FluentValidator;

namespace Store.Domain.StoreContext.Entities
{
    public class OrderItem : Notifiable
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;

            if (product.QuantityOnHand < quantity)
                AddNotification("Quantidade", $"Temos apenas {product.QuantityOnHand} unidades em estoque!");
        }

        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
