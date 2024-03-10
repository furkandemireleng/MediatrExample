using System.ComponentModel;

namespace MediatrExample.Entities;

public class ProductEntity
{
    public Guid Id { get; set; }
    public String Name { get; set; }
    public int Quantity { get; set; }
    public Decimal Value { get; set; }
}
