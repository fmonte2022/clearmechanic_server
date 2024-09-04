using ClearmechanicApi.Context;
using ClearmechanicApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class GenderController : Controller
{
    private readonly ApplicationDbContext _context;

    public GenderController(ApplicationDbContext context)
    {
        this._context = context;
    }

    // GET: api/Gender
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Gender>>> GetGenders()
    {
        return await _context.Genders.ToListAsync();
    }
}
