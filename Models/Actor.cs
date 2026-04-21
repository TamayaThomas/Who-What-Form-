using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;

public class Actor
{
    public int ActorID {get; set;}
    public int UserId {get; set;} //foreign key

    public int FilmID {get; set;}

    [Required]
    public string Fname {get; set;}
    [Required]
    public string Lname {get; set;}

    public string Project {get; set;}

    public Film Film {get; set;}

}