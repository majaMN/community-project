namespace CommunityProject.Core.Models
{
    public class SponsorshipPlan
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CommunityProjectId { get; set; }
        public string SourceOfFunds { get; set; }
        public string TypeOfFunds { get; set; }
        public string PaymentFrequency { get; set; }
        public decimal Amount { get; set; }
    }

}
