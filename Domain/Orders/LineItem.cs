using Domain.Products;

namespace Domain.Orders;

// Line Item can be treated as an entity or value-object, here it is used as an entity
public class LineItem
{
    // internal means that it can be instansiated only in Domain 
    internal LineItem(Guid id, Guid orderId, Guid productId, Money price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }
    public Guid Id { get; private set; }
    public Guid OrderId { get; private set; }
    public Guid ProductId { get; private set; }
    public Money Price { get; private set; }

}
