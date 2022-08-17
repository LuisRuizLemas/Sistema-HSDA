using Microsoft.EntityFrameworkCore;

namespace SistemaHSDA
{

    public class ClinicoContext : DbContext 
    {

    
    public ClinicoContext(DbContextOptions<ClinicoContext> opciones) : base(opciones)
    {

    }

     public DbSet<Clinico> Clinico { get; set; }

    }
}