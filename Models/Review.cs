using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Pages.models;

public class Review
{
    public int ReviewID {get; set;} //primary key 

    [Range(1, 5)]
    public int Score {get; set;}
    public string ReviewText {get; set;} = string.Empty;

    public int FilmID {get; set;} //primary key 

    public Film Film {get; set;}
}