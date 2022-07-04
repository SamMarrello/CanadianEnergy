using API.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Persistance;


public class Datacontext : IdentityDbContext<User>
{
    public Datacontext(DbContextOptions<Datacontext> options) : base(options)
    {
        
    }
    
    public DbSet<Province> Provinces { get; set; }
    public DbSet<PriceHistory> PriceHistories { get; set; }
}