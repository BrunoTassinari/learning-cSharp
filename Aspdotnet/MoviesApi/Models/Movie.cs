using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesAPI.Entities;

public class Movie
{
    [Column("id_movie")]
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Column("title")]
    [Required(ErrorMessage = "Title is required")]
    [MaxLength(50, ErrorMessage = "Title can't be longer than 50 characters")]
    public string Title { get; set; } = "";
    
    [Column("director")]
    [Required(ErrorMessage = "Director is required")]
    [MaxLength(50, ErrorMessage = "Director can't be longer than 50 characters")]
    public string Director { get; set; } = "";
    
    [Column("year")]
    [Required(ErrorMessage = "Year is required")]
    [Range(1900, 2023, ErrorMessage = "Year must be between 1900 and 2023")]
    public int Year { get; set; }
    
    [Column("duration")]
    [Required(ErrorMessage = "Duration is required")]
    [Range(20, 500, ErrorMessage = "Duration must be between 1 and 500")]
    
    public int Duration { get; set; }
    
    [Column("genre")]
    [Required(ErrorMessage = "Genre is required")]
    [MaxLength(50, ErrorMessage = "Genre can't be longer than 50 characters")]
    
    public string Genre { get; set; } = "";
}