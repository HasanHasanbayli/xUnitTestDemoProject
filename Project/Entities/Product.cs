using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Entities;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [Column(TypeName = "decimal(18,4)")] public decimal Quantity { get; set; }
    [Column(TypeName = "decimal(18,4)")] public decimal Price { get; set; }
}