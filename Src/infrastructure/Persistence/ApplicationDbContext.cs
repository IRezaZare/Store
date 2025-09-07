using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products => Set<Product>();
}
