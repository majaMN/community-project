using CommunityProject.Core.Models;

namespace CommunityProject.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<List<Payment>> GetPaymentsBySponsorshipPlanIdAsync(int sponsorshipPlanId);
    }
}
