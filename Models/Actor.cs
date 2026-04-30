using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;

public class Actor
{
    [Key]
    public int ActorID {get; set;}

    [Required]
    public int? FilmID {get; set;}

    [Required]
    [Display(Name = "First Name")]
    public string Fname {get; set;}
    [Required]
    [Display(Name = "Last Name")]
    public string Lname {get; set;}

    
    [Display(Name = "Actor Image")]
    public string ImageUrl { get; set; } = string.Empty;


    public Film? Film {get; set;}

}