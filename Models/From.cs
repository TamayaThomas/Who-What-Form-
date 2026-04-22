using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;


public class Source
{
    [Key]
    public int SourceID {get; set;} //pk
    public string SourceName  {get; set;} = string.Empty;

    public string SourceType  {get; set;} = string.Empty;

    public int FilmID  {get; set;}

    public Film Film { get; set; }
}