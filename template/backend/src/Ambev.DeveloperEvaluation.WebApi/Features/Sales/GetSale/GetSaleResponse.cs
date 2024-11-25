using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

public class GetSaleResponse
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