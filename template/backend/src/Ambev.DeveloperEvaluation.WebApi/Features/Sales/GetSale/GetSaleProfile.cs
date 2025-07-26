using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

public class GetSaleProfile : Profile
{
    public GetSaleProfile()
    {
        CreateMap<GetSaleResult, Sale>();
        CreateMap<GetSaleResult, Sale>().ReverseMap();
        CreateMap<GetSaleResult, GetSaleResponse>();
        CreateMap<GetSaleResult, GetSaleResponse>().ReverseMap();
    }
}