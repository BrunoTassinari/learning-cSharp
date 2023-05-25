using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Entities;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class MovieController : ControllerBase
{
    private MovieContext _context;
    private readonly IMapper _mapper;
    public MovieController(MovieContext movieContext, IMapper mapper)
    {
        _context = movieContext;
        _mapper = mapper;
    }
    
    [HttpPost]
    public IActionResult CreateMovie ([FromBody] CreateMovieDto movieDto)
    {
        var movie = _mapper.Map<Movie>(movieDto);
        _context.Movies.Add(movie);
        _context.SaveChanges();
        
        return CreatedAtAction(nameof(GetMovieByYear), new { id = movie.Id }, movie);
    }
    
    [HttpGet]
    public IEnumerable<ReadMovieDto> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        
        return _mapper.Map<List<ReadMovieDto>>(_context.Movies.Skip(skip).Take(take));
    }
    
    [HttpGet("{id}")]
    public IActionResult GetMovieByYear(int id)
    {
        var movie =  _context.Movies.FirstOrDefault(movie => movie.Id == id);
        if (movie == null) return NotFound();
        
        var movieDto = _mapper.Map<ReadMovieDto>(movie);
        
        return Ok(movieDto);
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDto movieDto)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
        if (movie == null) return NotFound();
        
        _mapper.Map(movieDto, movie);
        _context.SaveChanges();
        
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdatePartialMovie(int id, JsonPatchDocument<UpdateMovieDto> patchDocument)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
        if (movie == null) return NotFound();

        var movieToPatch = _mapper.Map<UpdateMovieDto>(movie);
        patchDocument.ApplyTo(movieToPatch, ModelState);
        
        if (!TryValidateModel(movieToPatch)) return ValidationProblem(ModelState);
        
        _mapper.Map(movieToPatch, movie);
        _context.SaveChanges();
        
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
        if (movie == null) return NotFound();
        
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        
        return NoContent();
    }
}