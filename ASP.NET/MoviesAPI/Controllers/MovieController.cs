using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class MovieController : ControllerBase
{

    private static List<Movie> _movies = new List<Movie>();

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        _movies.Add(movie);
    }
    
    [HttpGet]
    public List<Movie> GetMovies()
    {
        return _movies;
    }
    
    [HttpGet("{year}")]
    public List<Movie> GetMoviesByYear(int year)
    {
        return _movies.Where(movie => movie.Year == year).ToList();
    }

}