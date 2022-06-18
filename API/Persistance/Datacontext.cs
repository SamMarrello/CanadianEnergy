using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Persistance;


public class Datacontext : DbContext
{
    public Datacontext(DbContextOptions<Datacontext> options) : base(options)
    {
        
    }
    
    public DbSet<Province> Provinces { get; set; }
}