using CommunityProject.Core.Models;
using CommunityProject.Repository.Interfaces;
using CommunityProject.Services.Interfaces;

namespace CommunityProject.Services.Implementations
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<List<Payment>> GetPaymentsBySponsorshipPlanIdAsync(int sponsorshipPlanId)
        {
            try
            {
                var payments = await _paymentRepository.GetBySponsorshipPlanIdAsync(sponsorshipPlanId);
                return payments;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the payments.", ex);
            }
        }
    }


}
