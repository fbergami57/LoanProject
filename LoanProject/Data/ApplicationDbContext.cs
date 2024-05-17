using LoanProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanProject.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<LoanModel> Loans { get; set; }
}
