using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class MovieController : ControllerBase
{

    private static List<Movie> _movies = new List<Movie>();
    private static int _id = 0;
    

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        movie.Id = _id++;
        _movies.Add(movie);
    }
    
    [HttpGet]
    public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _movies.Skip(skip).Take(take);
    }
    
    [HttpGet("{id}")]
    public Movie? GetMoviesByYear(int id)
    {
        return _movies.FirstOrDefault(movie => movie.Id == id);
    }

}