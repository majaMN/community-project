using CommunityProject.Core.Models;
using CommunityProject.Repository;
using Microsoft.EntityFrameworkCore;

namespace CommunityProject.Data
{
    public static class DataSeeder
    {
        public static void SeedData(ApplicationDbContext dbContext)
        {
            // Ensure the database is created and apply any pending migrations
            dbContext.Database.EnsureCreated();
            dbContext.Database.Migrate();

            // Check if the database is already seeded
            if (dbContext.CommunityProjects.Any())
            {
                return; // Data already seeded
            }

            // Create sample community projects
            var projects = new List<VCommunityProject>
            {
                new VCommunityProject
                {
                    Name = "Project 1",
                    StartDate = DateTime.Now.AddDays(-7),
                    EndDate = DateTime.Now.AddDays(30),
                    TotalFundsRequired = 1000,
                    TotalFundsRaised = 500
                },
                new VCommunityProject
                {
                    Name = "Project 2",
                    StartDate = DateTime.Now.AddDays(-14),
                    EndDate = DateTime.Now.AddDays(45),
                    TotalFundsRequired = 2000,
                    TotalFundsRaised = 1000
                },
                // Add more sample projects as needed
            };

            // Create sample sponsorship plans
            var sponsorshipPlans = new List<SponsorshipPlan>
            {
               new SponsorshipPlan
                {
                    CustomerId = 12345,
                    SourceOfFunds = "Account",
                    CommunityProjectId = 1,
                    PaymentFrequency = "Monthly",
                    Amount = 100
                },
                new SponsorshipPlan
                {
                    CustomerId = 67890, 
                    SourceOfFunds = "Card",
                    CommunityProjectId = 2,
                    PaymentFrequency = "Weekly",
                    Amount = 50
                },
                // Add more sample sponsorship plans as needed
            };

            // Create sample payments
            var payments = new List<Payment>
            {
                new Payment
                {
                    SponsorshipPlanId = 1,
                    PaymentDate = DateTime.Now.AddDays(-7),
                    Amount = 100
                },
                new Payment
                {
                    SponsorshipPlanId = 2,
                    PaymentDate = DateTime.Now.AddDays(-14),
                    Amount = 50
                },
                // Add more sample payments as needed
            };

            // Add the sample data to the database
            dbContext.CommunityProjects.AddRange(projects);
            dbContext.SponsorshipPlans.AddRange(sponsorshipPlans);
            dbContext.Payments.AddRange(payments);
            dbContext.SaveChanges();
        }
    }
}
