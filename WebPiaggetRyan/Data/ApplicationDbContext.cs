using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPiaggetRyan.Models;

namespace WebPiaggetRyan.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<WebPiaggetRyan.Models.Aluno> Aluno { get; set; } = default!;
}
