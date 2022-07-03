using API.Application.Provinces;
using API.Domain;
using API.Persistance;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ProvinceController : BaseApiController
{
    
    [HttpGet]
    public async Task<IActionResult> GetProvinces()
    {
        return HandleResults(await Mediator.Send(new ListProvinces.Query()));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetProvince(int id)
    {
       var result = await Mediator.Send(new DetailsProvinces.Query {Id = id});

       return HandleResults(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProvince(int id, Province province)
    {
        province.Id = id;
        return Ok(await Mediator.Send(new UpdateProvinces.Command {Province = province}));
    }
}