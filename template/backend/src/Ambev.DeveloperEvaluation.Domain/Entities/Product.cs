using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Product : BaseEntity
{
    public Guid ItemId { get; set; }
    
    public string Name { get; set; } = string.Empty;

    //measurement unit, kg, liters, m, etc
    public string Unit { get; set; }

    //price of single item, item class multiplies by
    public double Price { get; set; }
}