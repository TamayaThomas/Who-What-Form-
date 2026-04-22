using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;

public class Film
{
    [Key]
    public int FilmID {get; set;} //primary key
    public int UserId {get; set;} //foreign key

    public string Title {get; set;} = string.Empty;

    
    public string Rating {get; set;} //G, PG, PG-13, R, or NC-17

    public string Description {get; set;} = string.Empty;

    [Display(Name = "Film Image")]
    public string ImageUrl { get; set; } = string.Empty;
    public List<Review> Reviews {get; set;} = new List<Review>();
    public List<Actor> Actors {get; set;}  = new List<Actor>();
    public List<Music> Musics {get;set;}= new List<Music>();
    public List<Source> Sources {get; set;}= new List<Source>();

    public Account Account {get; set;}
}