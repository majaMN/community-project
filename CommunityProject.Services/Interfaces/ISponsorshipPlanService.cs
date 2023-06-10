using CommunityProject.Core.Models;

namespace CommunityProject.Services.Interfaces
{
    public interface ISponsorshipPlanService
    {
        Task<SponsorshipPlan> CreateSponsorshipPlanAsync(SponsorshipPlan sponsorshipPlan);
        Task<List<SponsorshipPlan>> GetCustomerSponsorshipPlansAsync(int customerId);
        Task<SponsorshipPlan> UpdateSponsorshipPlanAsync(SponsorshipPlan sponsorshipPlan);
    }
}
