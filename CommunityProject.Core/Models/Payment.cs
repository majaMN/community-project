namespace CommunityProject.Core.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int SponsorshipPlanId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }

}
