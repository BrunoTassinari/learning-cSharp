using MoviesAPI.Entities;

namespace MoviesAPI.Utils;

public class Utils
{
    public static void ValidateMovie(Movie movie)
    {
        if(movie.Title == "" || movie.Title.Length > 100)
            throw new Exception("Title not valid");
        
        if(movie.Director == "" || movie.Director.Length > 100)
            throw new Exception("Director not valid");
        
        if(movie.Year is < 1900 or > 2023)
            throw new Exception("Year not valid");

    }
}