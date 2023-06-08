using Microsoft.AspNetCore.JsonPatch;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Entities;

namespace MoviesApi.Services;

public interface IMovieService
{
    public Movie create(CreateMovieDto movieDto);

    public List<ReadMovieDto> getAll(int skip, int take);

    public ReadMovieDto? getById(int id);

    public void update(int id, UpdateMovieDto movieDto);

    public void patch(int id, JsonPatchDocument<UpdateMovieDto> patchDocument);

    public void delete(int id);

}