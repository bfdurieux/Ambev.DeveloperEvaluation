using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.CreateCustomer;

public class CreateCustomerProfile : Profile
{
    public CreateCustomerProfile()
    {
        CreateMap<CreateCustomerCommand, Customer>();
        CreateMap<Customer, CreateCustomerResult>();
        CreateMap<CreateCustomerResult, Customer>();
        CreateMap<CreateCustomerResult, Customer>().ReverseMap();
        CreateMap<CreateCustomerResult, CreateCustomerResponse>();
        CreateMap<CreateCustomerResult, CreateCustomerResponse>().ReverseMap();
        CreateMap<CreateCustomerCommand, Customer>();
        CreateMap<CreateCustomerCommand, Customer>().ReverseMap();
        CreateMap<CreateCustomerRequest, CreateCustomerCommand>();
        CreateMap<CreateCustomerRequest, CreateCustomerCommand>().ReverseMap();
    }
}