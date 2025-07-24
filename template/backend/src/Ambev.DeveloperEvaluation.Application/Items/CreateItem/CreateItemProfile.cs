using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Items.CreateItem;

public class CreateItemProfile : Profile
{
    public CreateItemProfile()
    {
        CreateMap<CreateItemCommand, CreateItemResult>();
        CreateMap<CreateItemCommand, CreateItemResult>().ReverseMap();
    }
}