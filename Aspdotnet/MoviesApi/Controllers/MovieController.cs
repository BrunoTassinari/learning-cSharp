using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Entities;
using MoviesApi.Services;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;
    public MovieController(IMovieService service)
    {
     
        _movieService = service;
    }
    
    [HttpPost]
    public IActionResult CreateMovie ([FromBody] CreateMovieDto movieDto)
    {
        try
        {
           Movie createdMovie = _movieService.create(movieDto);
           return Ok(createdMovie);
           
        } catch (System.Exception)
        {
            return BadRequest();
        }
    }
    
    [HttpGet]
    public IEnumerable<ReadMovieDto> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        try
        {
            return _movieService.getAll(skip, take);
        }
        catch (System.Exception)
        {
            return null;
        }
    }
    
    [HttpGet("{id}")]
    public IActionResult GetMovieById(int id)
    {
        try
        {
           var movie =  _movieService.getById(id);
            return Ok(movie);
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDto movieDto)
    {
        try
        {
            _movieService.update(id, movieDto);
            return NoContent();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpPatch("{id}")]
    public IActionResult UpdatePartialMovie(int id, JsonPatchDocument<UpdateMovieDto> patchDocument)
    {
        try
        {
            _movieService.patch(id, patchDocument);
            return NoContent();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
        try
        {
            _movieService.delete(id);
            return NoContent();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }
}