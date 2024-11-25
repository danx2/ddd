using MediatR;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Application.SaleItems.CreateSaleItem;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

public class CreateSaleCommand : IRequest<CreateSaleResult>
{
    public string? SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public string? Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public string? Branch { get; set; }
    public List<CreateSaleItemCommand> SaleItems { get; set; } = [];

    public ValidationResultDetail Validate()
    {
        var validator = new CreateSaleCommandValidator();
        var result = validator.Validate(this);

        return new ValidationResultDetail(result);
    }
}
