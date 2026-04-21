using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;

public class Film
{
    public int FilmID {get; set;} //primary key
    public int UserId {get; set;} //foreign key

    public string Title {get; set;} = string.Empty;

    
    public string Rating {get; set;} //G, PG, PG-13, R, or NC-17

    public string Description {get; set;} = string.Empty;

    public List<Review> Reviews {get; set;}
    public List<Actor> Actors {get; set;}
}