using AutoMapper;
using ClearmechanicApi.Context;
using ClearmechanicApi.Models;
using ClearmechanicApi.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class MovieController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public MovieController(ApplicationDbContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }

    // GET: api/movies
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
    {
        return await _context.Movies.ToListAsync();
    }

    // GET: api/Movie/getByFilter?page=0&limit=10&q=xxxx&genderId=1&title=xxxx&actors=yyyyy
    [HttpGet("getByFilter")]
    public async Task<ActionResult<MovieResponseDTO>> GetByFilter(int page, int limit, String? q, int? genderId, String? title, String? actors)
    {
        //filter movies by criteria
        if (q != null && q.Length > 0)
        {
            var movies = await _context.Movies.Include(m => m.Gender).Include(m => m.MovieActors!).ThenInclude(m => m.Actor).Where(
                m => Convert.ToString(m.Year) == q || m.Title!.Contains(q) ||
                    m.Gender!.NameEn!.Contains(q) || m.Gender!.NameEs!.Contains(q) ||
                    m.MovieActors!.Any(a => a.Actor!.Name!.Contains(q))
            ).ToListAsync();

            return new MovieResponseDTO(_mapper.Map<List<MovieDTO>>(movies.Skip(page * limit).Take(limit).ToList()), movies.Count);
        }
        else

        //filter movies by gender and title and actors
        if (genderId != null || title != null || actors != null)
        {
            var movies = await _context.Movies.Include(m => m.Gender).Include(m => m.MovieActors!).ThenInclude(m => m.Actor).Where(
               m => (genderId != null && m.GenderId == genderId || genderId == null) &&
                   (title != null && m.Title!.Contains(title) || title == null) &&
                    (actors != null && m.MovieActors!.Any(a => a.Actor!.Name!.Contains(actors)) || actors == null)
           ).ToListAsync();

            return new MovieResponseDTO(_mapper.Map<List<MovieDTO>>(movies.Skip(page * limit).Take(limit).ToList()), movies.Count);
        }
        else
        {
            //get all movies without filters
            var movies = await _context.Movies.Include(m => m.Gender).Include(m => m.MovieActors!).ThenInclude(m => m.Actor).ToListAsync();
            return new MovieResponseDTO(_mapper.Map<List<MovieDTO>>(movies.Skip(page * limit).Take(limit).ToList()), movies.Count);
        }
    }
}
