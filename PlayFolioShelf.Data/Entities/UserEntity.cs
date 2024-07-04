using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using PlayFolioShelf.Models;

namespace PlayFolioShelf.Data.Entities;

public class UserEntity : IdentityUser<int>
{
    [Required]
    [MaxLength(100)]
    public string FirstName {get; set;} = string.Empty;
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public DateTime DateCreated { get; set; }
    
}
