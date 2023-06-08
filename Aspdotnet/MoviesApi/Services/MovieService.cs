using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Data.Repository;
using MoviesAPI.Entities;

namespace MoviesApi.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;
    
    public MovieService(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }
    
    public Movie create(CreateMovieDto movieDto)
    {
        Movie movie = _mapper.Map<Movie>(movieDto);
        _movieRepository.create(movie);

        return movie;
    }
    
    public List<ReadMovieDto> getAll(int skip, int take)
    {
        return _mapper.Map<List<ReadMovieDto>>(_movieRepository.getAll(skip, take));
    }
    
    public ReadMovieDto? getById(int id)
    {
        Movie movie = _movieRepository.getById(id);
        if (movie == null) return null;
        
        return _mapper.Map<ReadMovieDto>(movie);
    }
    
    public void update(int id, UpdateMovieDto movieDto)
    {
        Movie movie = _movieRepository.getById(id);
        if (movie == null) return;
        
        _mapper.Map(movieDto, movie);
        _movieRepository.save();
        
    }

    public void patch(int id, JsonPatchDocument<UpdateMovieDto> patchDocument)
    {
        Movie movie = _movieRepository.getById(id);
        if (movie == null) return;  
        
        UpdateMovieDto movieDto = _mapper.Map<UpdateMovieDto>(movie);
        patchDocument.ApplyTo(movieDto);
        
        _mapper.Map(movieDto, movie);
        _movieRepository.save();
    }
    
    public void delete(int id)
    {
        _movieRepository.delete(id);
    }
    
}   