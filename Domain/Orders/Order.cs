using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

// this is commonly refered to as an aggregate 
// as an exampple Order object encapsulate all of the other entities, value object belonging to that aggregate
public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();

    private Order()
    {

    }
    public Guid Id { get; private set; }

    public Guid CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),
            CustomerId = customer.Id
        };
        return order;
    }



    // the reason that we don't pass product id is that it's not clear what that Guid represent for
    public void Add(Product product)
    {
        var lineItem = new LineItem(Guid.NewGuid(), Id, product.Id, product.Price);
        _lineItems.Add(lineItem);
    }
}
