using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

public class UpdateSaleProfile : Profile
{
    public UpdateSaleProfile()
    {
        CreateMap<UpdateSaleCommand, UpdateSaleResult>();
        CreateMap<UpdateSaleCommand, UpdateSaleResult>().ReverseMap();
        CreateMap<UpdateSaleCommand, Sale>();
        CreateMap<UpdateSaleCommand, Sale>().ReverseMap();
        CreateMap<Sale, UpdateSaleResult>();
        CreateMap<Sale, UpdateSaleResult>().ReverseMap();
    }
}