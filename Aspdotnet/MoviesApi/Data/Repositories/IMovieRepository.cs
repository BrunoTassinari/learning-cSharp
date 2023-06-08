using MoviesAPI.Entities;

namespace MoviesAPI.Data.Repository;

public interface IMovieRepository
{
    
    void create(Movie movie);
    void save();
    List<Movie> getAll(int skip, int take);
    Movie? getById(int id);
    void delete(int id);
}