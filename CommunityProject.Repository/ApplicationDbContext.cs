using CommunityProject.Core.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Define your entity DbSet properties here
    public DbSet<VCommunityProject> CommunityProjects { get; set; }
    public DbSet<SponsorshipPlan> SponsorshipPlans { get; set; }
    public DbSet<Payment> Payments { get; set; }
}
