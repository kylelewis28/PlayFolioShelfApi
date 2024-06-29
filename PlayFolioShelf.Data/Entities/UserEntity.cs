using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using PlayFolioShelf.Models;

namespace PlayFolioShelf.Data.Entities;

public class UserEntity : IdentityUser<int>
{
    [MaxLength(100)]
    public string FirstName {get; set;}
    [MaxLength(100)]
    public string LastName { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }   
    
}
