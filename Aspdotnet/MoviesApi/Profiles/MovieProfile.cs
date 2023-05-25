using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Entities;

namespace MoviesApi.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
        CreateMap<Movie, ReadMovieDto>();
        CreateMap<Movie, UpdateMovieDto>();
    }
}

