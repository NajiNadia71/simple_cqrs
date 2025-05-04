using Microsoft.AspNetCore.Mvc;
using adsCompany.DTO;

using adsCompnay.ViewModels;
using adsCompany.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using MediatR;
using System.Text.Json;
namespace Service_Back.Controllers
{
[ApiController]
[Route("apicqrs/[controller]")]
public class All_CQRSController : ControllerBase
{
    private readonly IMediator _mediator;

    public All_CQRSController(IMediator mediator)
    {
        _mediator = mediator;
    }
        [HttpGet("Test")]
        public IEnumerable<int> Test()
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<ProductionDTO>>> GetAll()
        {
            return await _mediator.Send(new GetProductionsQuery());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductionDTO>> GetById(int id)
        {
            return await _mediator.Send(new GetProductionByIdQuery { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateProductionCommand command)
        {
            return await _mediator.Send(command);
        }
        //[HttpGet]
        //public async Task<ActionResult<List<ProductionDTO>>> GetAll()
        //{
        //    return await _mediator.Send(new GetProductionsQuery());
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<ProductionDTO>> GetById(int id)
        //{
        //    return await _mediator.Send(new GetProductionByIdQuery { Id = id });
        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> Create(CreateProductionCommand command)
        //{
        //    return await _mediator.Send(command);
        //}
    }
}