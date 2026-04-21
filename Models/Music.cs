using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;

public class Music
{
    public int SongID  {get; set;}
    
    [Required]
    public string SongTitle  {get; set;}

    public string ArtistName  {get; set;} = string.Empty;

    public int FilmID  {get; set;}

    public Film Film { get; set; }
}