namespace Proxy;

public interface IChief
{
    IEnumerable<Order> GetOrders();
    IDictionary<int, string> GetStatuses();
}