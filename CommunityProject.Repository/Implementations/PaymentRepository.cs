using CommunityProject.Core.Models;
using CommunityProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityProject.Repository.Implementations
{
    public class PaymentRepository : IPaymentRepository 
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> GetBySponsorshipPlanIdAsync(int sponsorshipPlanId)
        {
            try
            {
                var payments = await _context.Payments
                    .Where(p => p.SponsorshipPlanId == sponsorshipPlanId)
                    .ToListAsync();
                return payments;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the payments.", ex);
            }
        }
    }
}
