using CommunityProject.Core.Models;
using Microsoft.AspNetCore.Mvc;
using CommunityProject.Services.Interfaces;

namespace CommunityProject.API.Controllers
{
    [ApiController]
    [Route("api/sponsorship-plans")]
    public class SponsorshipPlanController : ControllerBase
    {
        private readonly ISponsorshipPlanService _sponsorshipPlanService;

        public SponsorshipPlanController(ISponsorshipPlanService sponsorshipPlanService)
        {
            _sponsorshipPlanService = sponsorshipPlanService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSponsorshipPlan([FromBody] SponsorshipPlan sponsorshipPlan)
        {
            try
            {
                var createdPlan = await _sponsorshipPlanService.CreateSponsorshipPlanAsync(sponsorshipPlan);
                return Ok(createdPlan);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the sponsorship plan.");
            }
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetCustomerSponsorshipPlans(int customerId)
        {
            try
            {
                var plans = await _sponsorshipPlanService.GetCustomerSponsorshipPlansAsync(customerId);
                return Ok(plans);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while retrieving the customer's sponsorship plans.");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSponsorshipPlan([FromBody] SponsorshipPlan sponsorshipPlan)
        {
            try
            {
                var updatedPlan = await _sponsorshipPlanService.UpdateSponsorshipPlanAsync(sponsorshipPlan);
                return Ok(updatedPlan);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while updating the sponsorship plan.");
            }
        }
    }

}
