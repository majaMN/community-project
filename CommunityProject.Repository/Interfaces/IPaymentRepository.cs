using CommunityProject.Core.Models;

namespace CommunityProject.Repository.Interfaces
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetBySponsorshipPlanIdAsync(int sponsorshipPlanId);
    }
}
