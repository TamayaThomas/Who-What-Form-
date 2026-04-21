using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
namespace Who_What_Form_.Models;

public class Account
{
    [Key]
    public int UsedId {get; set;} //primary key 
    
    [Required]
    [StringLength(25)]
    public string Username {get; set;}
    
    [Required]
    [EmailAddress]
    public string Email {get; set;}
   
    [Required]
    [StringLength(25)]
    public string Password {get; set;}
}