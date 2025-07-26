using Ambev.DeveloperEvaluation.Application.Branches.GetBranch;
using Ambev.DeveloperEvaluation.Application.Branches.ListBranches;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.GetBranch;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches;

[ApiController]
[Route("api/[controller]")]
public class BranchesController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public BranchesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet("{location}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetBranchResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetBranch([FromRoute] string location, CancellationToken cancellationToken)
    {
        if (location.IsNullOrEmpty())
            return BadRequest("Location is required");

        var command = _mapper.Map<GetBranchCommand>(location);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<GetBranchResponse>
        {
            Success = true,
            Message = "Branch retrieved successfully",
            Data = _mapper.Map<GetBranchResponse>(response)
        });
    }


    [HttpGet]
    [ProducesResponseType(typeof(ApiResponseWithData<ListBranchesResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListBranches(CancellationToken cancellationToken)
    {
        var command = new ListBranchesCommand();
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(response.Branches);
    }
    
    
    
}