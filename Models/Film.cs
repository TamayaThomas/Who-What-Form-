using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Pages.models;

public class Film
{
    public int FilmID {get; set;} //primary key

    public string Name {get; set;} = string.Empty;

    public string Description {get; set;} = string.Empty;

    public List<Review> Reviews {get; set;}
}