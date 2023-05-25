namespace MoviesAPI.Data.Dtos;

public class ReadMovieDto
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Director { get; set; } = "";
    public int Year { get; set; }
    public int Duration { get; set; }
    public string Genre { get; set; } = "";
    public DateTime consulted_at { get; set; } = DateTime.Now;
}