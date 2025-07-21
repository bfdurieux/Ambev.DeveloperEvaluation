
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    //measurement unit, kg, liters, m, etc
    public Unit Unit { get; set; }

    //price of single item, item class multiplies by
    public decimal Price { get; set; }
}