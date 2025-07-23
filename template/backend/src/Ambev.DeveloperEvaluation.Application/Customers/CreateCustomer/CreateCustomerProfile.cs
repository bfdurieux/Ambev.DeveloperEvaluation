using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;

public class CreateCustomerProfile : Profile
{
    public CreateCustomerProfile()
    {
        CreateMap<CreateCustomerCommand, Customer>();
        CreateMap<Customer, CreateCustomerResult>();
        CreateMap<CreateCustomerResult, Customer>();
        CreateMap<CreateCustomerResult, Customer>().ReverseMap();
        CreateMap<CreateCustomerCommand, Customer>();
        CreateMap<CreateCustomerCommand, Customer>().ReverseMap();
    }
}