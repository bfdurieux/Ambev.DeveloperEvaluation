using Ambev.DeveloperEvaluation.Application.Items.CreateItem;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Items.CreateItems;

public class CreateItemProfile : Profile
{
    public CreateItemProfile()
    {
        CreateMap<CreateItemRequest, CreateItemCommand>();
        CreateMap<CreateItemRequest, CreateItemCommand>().ReverseMap();
        CreateMap<CreateItemResponse, CreateItemCommand>();
        CreateMap<CreateItemResponse, CreateItemCommand>().ReverseMap();
        CreateMap<Item, CreateItemCommand>();
        CreateMap<Item, CreateItemCommand>().ReverseMap();
        CreateMap<CreateItemResponse, CreateItemResult>();
        CreateMap<CreateItemResponse, CreateItemResult>().ReverseMap();
    }
}