using Microsoft.AspNetCore.Identity;

namespace API.Domain;

public class User : IdentityUser
{
    public string DisplayName { get; set; }
    
}