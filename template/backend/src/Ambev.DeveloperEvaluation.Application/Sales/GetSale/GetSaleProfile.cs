using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

public class GetSaleProfile : Profile
{
    public GetSaleProfile()
    {
        CreateMap<GetSaleResult, Sale>();
        CreateMap<GetSaleResult, Sale>().ReverseMap();
        CreateMap<Guid, GetSaleCommand>();
        CreateMap<Guid, GetSaleCommand>().ReverseMap();
    }
}