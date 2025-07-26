using Ambev.DeveloperEvaluation.Application.Items.UpdateItem;
using Ambev.DeveloperEvaluation.Domain.Entities;
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
        CreateMap<UpdateItemCommand, UpdateItemRequest>();
        CreateMap<UpdateItemCommand, UpdateItemRequest>().ReverseMap();
        CreateMap<UpdateItemCommand, Item>();
        CreateMap<UpdateItemCommand, Item>().ReverseMap();
        CreateMap<UpdateItemResult, Item>();
        CreateMap<UpdateItemResult, Item>().ReverseMap();
    }
}