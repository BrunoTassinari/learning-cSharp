using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Entities;

public class Movie
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is required")]
    [MaxLength(50, ErrorMessage = "Title can't be longer than 50 characters")]
    public string Title { get; set; } = "";
    
    [Required(ErrorMessage = "Director is required")]
    [MaxLength(50, ErrorMessage = "Director can't be longer than 50 characters")]
    public string Director { get; set; } = "";
    
    [Required(ErrorMessage = "Year is required")]
    [Range(1900, 2023, ErrorMessage = "Year must be between 1900 and 2023")]
    public int Year { get; set; }
    
    [Required(ErrorMessage = "Duration is required")]
    [Range(20, 500, ErrorMessage = "Duration must be between 1 and 500")]
    
    public int Duration { get; set; }
    
    [Required(ErrorMessage = "Genre is required")]
    [MaxLength(50, ErrorMessage = "Genre can't be longer than 50 characters")]
    
    public string Genre { get; set; } = "";
}