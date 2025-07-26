using Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

public class UpdateSaleProfile : Profile
{
    public UpdateSaleProfile()
    {
        CreateMap<UpdateSaleRequest, Sale>();
        CreateMap<UpdateSaleRequest, Sale>().ReverseMap();
        CreateMap<UpdateSaleResponse, Sale>();
        CreateMap<UpdateSaleResponse, Sale>().ReverseMap();
        CreateMap<UpdateSaleRequest, UpdateSaleResponse>();
        CreateMap<UpdateSaleRequest, UpdateSaleResponse>().ReverseMap();
        CreateMap<UpdateSaleCommand, UpdateSaleRequest>();
        CreateMap<UpdateSaleCommand, UpdateSaleRequest>().ReverseMap();
        CreateMap<UpdateSaleCommand, UpdateSaleResponse>();
        CreateMap<UpdateSaleCommand, UpdateSaleResponse>().ReverseMap();
    }
}