using ClearmechanicApi.Context;
using ClearmechanicApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly ApplicationDbContext _context;

    public UserController(ApplicationDbContext context)
    {
        this._context = context;
    }

    // GET: api/users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    // GET: api/users/validateUser?userName=a&password=b
    [HttpGet("validateUser")]
    public async Task<ActionResult<User>> ValidateUser(String userName, String password)
    {
        var user = await _context.Users.Where(u => u.Username == userName && u.Password == password).FirstOrDefaultAsync();

        if (user == null)
        {
            return NotFound();
        }

        return user;
    }
}
