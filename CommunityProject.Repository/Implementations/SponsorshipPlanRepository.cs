using CommunityProject.Core.Models;
using CommunityProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityProject.Repository.Implementations
{
    public class SponsorshipPlanRepository : ISponsorshipPlanRepository
    {
        private readonly ApplicationDbContext _context;

        public SponsorshipPlanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SponsorshipPlan> AddAsync(SponsorshipPlan sponsorshipPlan)
        {
            try
            {
                await _context.SaveChangesAsync();
                return sponsorshipPlan;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the sponsorship plan.", ex);
            }
        }

        public async Task<List<SponsorshipPlan>> GetByCustomerIdAsync(int customerId)
        {
            try
            {
                var plans = await _context.SponsorshipPlans
                    .Where(p => p.CustomerId == customerId)
                    .ToListAsync();
                return plans;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the sponsorship plans.", ex);
            }
        }

        public async Task<SponsorshipPlan> UpdateAsync(SponsorshipPlan sponsorshipPlan)
        {
            try
            {
                await _context.SaveChangesAsync();
                return sponsorshipPlan;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the sponsorship plan.", ex);
            }
        }
    }

}
