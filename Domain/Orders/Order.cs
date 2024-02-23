using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

// this is commonly refered to as an aggregate 
// as an exampple Order object encapsulate all of the other entities, value object belonging to that aggregate
public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();

    private Order() {}
    public OrderId Id { get; private set; }

    public CustomerId CustomerId { get; private set; }

    public IReadOnlyList<LineItem> LineItems => _lineItems.ToList();

    public static Order Create(CustomerId customerId)
    {
        var order = new Order
        {
            Id = new OrderId(Guid.NewGuid()),
            CustomerId = customerId
        };
        return order;
    }

    // the reason that we don't pass product id is that it's not clear what that Guid represent for
    public void Add(ProductId productId, Money price)
    {
        var lineItem = new LineItem(
            new LineItemId(Guid.NewGuid())
            , Id
            , productId
            , price);
        _lineItems.Add(lineItem);
    }
}
