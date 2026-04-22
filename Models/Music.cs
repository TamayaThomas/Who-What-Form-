using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;

public class Music
{
    [Key]
    public int SongID  {get; set;}
    
    [Required]
    public string SongTitle  {get; set;}

    [Required]
    public string ArtistName  {get; set;} = string.Empty;
    
    [Display(Name = "Artist Image")]
    public string ImageUrl { get; set; } = string.Empty;

    public int FilmID  {get; set;}

    public Film Film { get; set; }
}