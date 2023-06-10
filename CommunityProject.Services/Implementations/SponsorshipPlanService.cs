using CommunityProject.Core.Models;
using CommunityProject.Repository.Interfaces;
using CommunityProject.Services.Interfaces;

namespace CommunityProject.Services.Implementations
{
    public class SponsorshipPlanService : ISponsorshipPlanService
    {
        private readonly ISponsorshipPlanRepository _sponsorshipPlanRepository;

        public SponsorshipPlanService(ISponsorshipPlanRepository sponsorshipPlanRepository)
        {
            _sponsorshipPlanRepository = sponsorshipPlanRepository;
        }

        public async Task<SponsorshipPlan> CreateSponsorshipPlanAsync(SponsorshipPlan sponsorshipPlan)
        {
            try
            {
                // Validate the sponsorship plan

                var createdPlan = await _sponsorshipPlanRepository.AddAsync(sponsorshipPlan);
                return createdPlan;
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new InvalidOperationException("An error occurred while creating the sponsorship plan.", ex);
            }
        }

        public async Task<List<SponsorshipPlan>> GetCustomerSponsorshipPlansAsync(int customerId)
        {
            try
            {
                var plans = await _sponsorshipPlanRepository.GetByCustomerIdAsync(customerId);
                return plans;
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new InvalidOperationException("An error occurred while retrieving the customer's sponsorship plans.", ex);
            }
        }

        public async Task<SponsorshipPlan> UpdateSponsorshipPlanAsync(SponsorshipPlan sponsorshipPlan)
        {
            try
            {
                // Validate the sponsorship plan

                var updatedPlan = await _sponsorshipPlanRepository.UpdateAsync(sponsorshipPlan);
                return updatedPlan;
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new InvalidOperationException("An error occurred while updating the sponsorship plan.", ex);
            }
        }
    }


}
