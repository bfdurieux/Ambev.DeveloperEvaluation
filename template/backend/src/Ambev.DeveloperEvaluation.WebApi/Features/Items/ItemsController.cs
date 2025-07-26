using Ambev.DeveloperEvaluation.Application.Items.CreateItem;
using Ambev.DeveloperEvaluation.Application.Items.UpdateItem;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Items.CreateItems;
using Ambev.DeveloperEvaluation.WebApi.Features.Items.UpdateItem;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Items;


[ApiController]
[Route("api/[controller]")]
public class ItemsController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public ItemsController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    //create
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateItemResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateItem([FromBody] CreateItemRequest request,
        CancellationToken cancellationToken)
    {
        var command = _mapper.Map<CreateItemCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateItemResponse>
        {
            Success = true,
            Message = "Item created successfully",
            Data = _mapper.Map<CreateItemResponse>(response)
        });
    }

    [HttpPut]
    [ProducesResponseType(typeof(ApiResponseWithData<UpdateItemResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateItem([FromBody] UpdateItemRequest request,
        CancellationToken cancellationToken)
    {
        var command = _mapper.Map<UpdateItemCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);
        return Ok(response);
    }
}