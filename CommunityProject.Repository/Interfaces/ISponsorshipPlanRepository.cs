using CommunityProject.Core.Models;

namespace CommunityProject.Repository.Interfaces
{
    public interface ISponsorshipPlanRepository
    {
        Task<SponsorshipPlan> AddAsync(SponsorshipPlan sponsorshipPlan);
        Task<List<SponsorshipPlan>> GetByCustomerIdAsync(int customerId);
        Task<SponsorshipPlan> UpdateAsync(SponsorshipPlan sponsorshipPlan);
    }
}
