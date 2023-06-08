using MoviesAPI.Entities;

namespace MoviesAPI.Data.Repository;

public class MovieRepository : IMovieRepository
{
    private readonly MovieContext _context;
    
    public MovieRepository(MovieContext context)
    {
        _context = context;
    }
    
    public void create(Movie movie)
    {
        _context.Movies.Add(movie);
        this.save();
    }
    public void save ()
    {
        _context.SaveChanges();
    }

    public List<Movie> getAll(int skip, int take)
    {
       return new List<Movie>(_context.Movies.Skip(skip).Take(take));
    }

    public Movie? getById(int id)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
        return movie ?? null;
    }

    public void delete(int id)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
        if (movie == null) return;
        
        _context.Movies.Remove(movie);
        this.save();
    }
}