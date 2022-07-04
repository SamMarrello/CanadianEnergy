using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [RequireHttps]
    [Route("api/[Controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator;

        protected ActionResult HandleResults<T>(Result<T> result)
        {
            if (result == null)
            {
                return NotFound();
            }
            
            if(result.IsSuccess && result.Value != null)
            {
                return Ok(result.Value);
            }

            if(result.IsSuccess && result.Value == null)
            {
                return NotFound();
            }

            return BadRequest(result.Error);
        }
    }
}
