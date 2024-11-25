using Ambev.DeveloperEvaluation.Application.SaleItems.CreateSaleItem;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
{
    public CreateSaleCommandValidator()
    {
        RuleFor(sale => sale.SaleNumber).NotEmpty();
        RuleFor(sale => sale.SaleDate).NotEmpty();
        RuleFor(sale => sale.Customer).NotEmpty();
        RuleFor(sale => sale.TotalAmount).GreaterThan(0);
        RuleFor(sale => sale.Branch).NotEmpty();
        RuleFor(sale => sale.SaleItems).NotEmpty();
        RuleForEach(sale => sale.SaleItems).SetValidator(new CreateSaleItemCommandValidator());
    }
}