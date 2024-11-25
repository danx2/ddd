using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

namespace Ambev.DeveloperEvaluation.WebApi.Sales.GetSale;

public class GetSaleProfile : Profile
{
    public GetSaleProfile()
    {
        CreateMap<Guid, GetSaleCommand>()
            .ConstructUsing(id => new GetSaleCommand(id));

        CreateMap<GetSaleResult, GetSaleResponse>();
    }
}
