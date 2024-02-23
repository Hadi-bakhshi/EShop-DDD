using Domain.Products;

namespace Domain.Orders;

// Line Item can be treated as an entity or value-object, here it is used as an entity
public class LineItem
{

    public LineItemId Id { get; private set; }
    public OrderId OrderId { get; private set; }
    public ProductId ProductId { get; private set; }
    public Money Price { get; private set; }

    private LineItem() { }
    // internal means that it can be instansiated only in Domain 
    internal LineItem(LineItemId id, OrderId orderId, ProductId productId, Money price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }

}
