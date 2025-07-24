using Ambev.DeveloperEvaluation.Application.Items.UpdateItem;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Items.UpdateItem;

public class UpdateItemProfile : Profile
{
    public UpdateItemProfile()
    {
        CreateMap<UpdateItemCommand, UpdateItemResult>();
        CreateMap<UpdateItemCommand, UpdateItemResult>().ReverseMap();
        CreateMap<UpdateItemResponse, UpdateItemResult>();
        CreateMap<UpdateItemResponse, UpdateItemResult>().ReverseMap();
    }
}