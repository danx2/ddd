using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

public class GetSaleResult
{
    public Guid Id { get; set; }
    public string? SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public string? Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public string? Branch { get; set; }
    public List<SaleItem> SaleItems { get; set; } = [];
    public bool IsCancelled { get; set; }
}
