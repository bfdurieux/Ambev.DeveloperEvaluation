using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

public class CreateSaleProfile : Profile
{
    public CreateSaleProfile()
    {
        // CreateSaleCommand -> Sale
        CreateMap<CreateSaleCommand, Sale>();
        CreateMap<CreateSaleCommand, Sale>().ReverseMap();
        CreateMap<CreateSaleResult, Sale>();
        CreateMap<CreateSaleResult, Sale>().ReverseMap();
        // CreateMap<CreateSaleResult, CreateSaleResponse>().ReverseMap();
    }
    
}