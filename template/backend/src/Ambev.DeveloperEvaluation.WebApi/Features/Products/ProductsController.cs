using Ambev.DeveloperEvaluation.Application.Products.ListProducts;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Common;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : BaseController
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public ProductsController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(typeof(ApiResponseWithData<List<Product>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAllProducts(CancellationToken cancellationToken)
    {
        //TODO: remove magic number
        var command = _mapper.Map<ListProductsCommand>(10);
        var products = await _mediator.Send(command, cancellationToken);
        return Ok(new ApiResponseWithData<List<Product>>
        {
            Success = true,
            Message = "Users retrieved successfully",
            Data = products.Products.ToList()
        });
    }
}