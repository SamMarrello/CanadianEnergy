using API.Domain;
using API.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ProvinceController : BaseApiController
{
    private readonly Datacontext _context;

    public ProvinceController(Datacontext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Province>>> GetProvinces()
    {
        return await _context.Provinces.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Province>> GetProvince(int id)
    {
        return await _context.Provinces.FindAsync(id);
    }
}