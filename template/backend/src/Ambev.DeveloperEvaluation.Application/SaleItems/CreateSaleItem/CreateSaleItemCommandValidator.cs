using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.CreateSaleItem;

public class CreateSaleItemCommandValidator : AbstractValidator<CreateSaleItemCommand>
{
    private const int MinQuantityForDiscount = 4;
    private const int MaxQuantityForDiscount = 20;
    private const decimal DiscountFor4To9Items = 0.10m;
    private const decimal DiscountFor10To20Items = 0.20m;

    public CreateSaleItemCommandValidator()
    {
        RuleFor(item => item.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than 0")
            .LessThanOrEqualTo(20).WithMessage("Cannot sell more than 20 identical items");

        RuleFor(item => item.Discount)
            .Must((item, discount) => ValidateDiscount(item.Quantity, discount))
            .WithMessage("Invalid discount for the given quantity");

        RuleFor(item => item.TotalAmount)
            .GreaterThan(0).WithMessage("Total amount must be greater than 0");
    }

    private bool ValidateDiscount(int quantity, decimal discount)
    {
        if (quantity < MinQuantityForDiscount && discount > 0)
        {
            return false; // No discount allowed for quantities below 4 items
        }

        if (quantity >= MinQuantityForDiscount && quantity < 10 && discount != DiscountFor4To9Items)
        {
            return false; // 10% discount for 4-9 items
        }

        if (quantity >= 10 && quantity <= MaxQuantityForDiscount && discount != DiscountFor10To20Items)
        {
            return false; // 20% discount for 10-20 items
        }

        return true;
    }
}
