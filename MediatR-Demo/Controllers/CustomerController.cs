using MediatR;
using MediatR_Demo.Application.CQRS.Command;
using MediatR_Demo.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] Account account)
        {
            //TODO: Use AutoMapper for mappings


            var result = await _mediator.Send(new CreateCustomerCommand
            {
                Account = account
            });

            return Ok(result);
        }
    }
}
