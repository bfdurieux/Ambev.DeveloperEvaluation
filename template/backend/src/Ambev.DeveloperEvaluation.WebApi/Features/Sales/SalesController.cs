using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.Sales.ListSales;
using Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;
using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSales;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUser;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales;

[ApiController]
[Route("api/[controller]")]
public class SalesController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public SalesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetUserResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetSale([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new GetUserRequest { Id = id };
        var validator = new GetUserRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<GetUserCommand>(request.Id);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<GetUserResponse>
        {
            Success = true,
            Message = "User retrieved successfully",
            Data = _mapper.Map<GetUserResponse>(response)
        });
    }


    [HttpGet]
    [ProducesResponseType(typeof(ApiResponseWithData<List<Sale>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListSales(CancellationToken cancellationToken)
    {
        var command = _mapper.Map<ListSalesCommand>(new ListSalesRequest());
        var sales = await _mediator.Send(command, cancellationToken);
        return Ok(new ApiResponseWithData<List<Sale>>
        {
            Success = true,
            Message = "Sales retrieved successfully",
            Data = sales.Sales.ToList()
        });
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateSaleResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateSale([FromBody] CreateSaleRequest request, CancellationToken cancellationToken)
    {
        // var validator = new CreateUserRequestValidator();
        // var validationResult = await validator.ValidateAsync(request, cancellationToken);

        // if (!validationResult.IsValid)
        //     return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreateSaleCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateSaleResponse>
        {
            Success = true,
            Message = "User created successfully",
            Data = _mapper.Map<CreateSaleResponse>(response)
        });
    }


    [HttpPut]
    [ProducesResponseType(typeof(ApiResponseWithData<UpdateSaleResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateSale([FromBody] UpdateSaleRequest request,
        CancellationToken cancellationToken)
    {
        var testSaleId = "5b46c029-3fe7-4cac-ac8f-293a013922f1";
        var customerId = "1e6182ad-4be4-4c50-82b7-792a340da072";
        var branchId = "fe4d5174-387d-4271-8421-137d4ebf2222";
        var productId1 = "708cecfa-5e03-4719-b43a-93e83c4765f4";
        var productId2 = "b9428b98-1df2-4b82-b141-baaeb7ceabaf";
        var items = new List<Item>();
        items.Add(new Item
        {
            Discount = 0,
            SaleId = Guid.Parse(testSaleId),
            IsCancelled = false,
            Quantity = 25,
            ProductId = Guid.Parse(productId1)
        });

        items.Add(new Item
        {
            Discount = 0,
            SaleId = Guid.Parse(testSaleId),
            IsCancelled = false,
            Quantity = 4,
            ProductId = Guid.Parse(productId2)
        });

        request.Items = items;
        request.BranchId = Guid.Parse(branchId);
        request.CustomerId = Guid.Parse(customerId);
        request.Id = Guid.Parse(testSaleId);
        request.Date = DateTime.Now;

        var command = _mapper.Map<UpdateSaleCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<UpdateSaleResponse>
        {
            Success = true,
            Message = "User created successfully",
            Data = _mapper.Map<UpdateSaleResponse>(response)
        });
    }



}