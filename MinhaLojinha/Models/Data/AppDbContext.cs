using Microsoft.EntityFrameworkCore;
namespace MinhaLojinha.Models.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products {get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlite("Data Source=lojinha.db");
    }
} 