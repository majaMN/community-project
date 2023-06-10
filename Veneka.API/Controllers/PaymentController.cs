using Microsoft.AspNetCore.Mvc;
using CommunityProject.Services.Interfaces;

namespace CommunityProject.API.Controllers
{
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("{sponsorshipPlanId}")]
        public async Task<IActionResult> GetPaymentsBySponsorshipPlanId(int sponsorshipPlanId)
        {
            try
            {
                var payments = await _paymentService.GetPaymentsBySponsorshipPlanIdAsync(sponsorshipPlanId);
                return Ok(payments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving the payments.");
            }
        }

    }
}
