namespace Proxy;

public struct Order
{
    public Order(Guid id, string? name, int statusId)
    {
        Id = id;
        Name = name;
        StatusId = statusId;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public int StatusId { get; set; }
}
