using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Entities;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class MovieController : ControllerBase
{
    private MovieContext _context;
    public MovieController(MovieContext movieContext)
    {
        _context = movieContext;
    }
    
    [HttpPost]
    public IActionResult CreateMovie ([FromBody] Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
        
        return CreatedAtAction(nameof(GetMovieByYear), new { id = movie.Id }, movie);
    }
    
    [HttpGet]
    public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _context.Movies.Skip(skip).Take(take);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetMovieByYear(int id)
    {
        var movie =  _context.Movies.FirstOrDefault(movie => movie.Id == id);
        if (movie == null) return NotFound();
        
        return Ok(movie);
    }

}