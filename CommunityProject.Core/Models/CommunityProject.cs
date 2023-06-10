namespace CommunityProject.Core.Models
{
    public class VCommunityProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalFundsRequired { get; set; }
        public decimal TotalFundsRaised { get; set; }
    }

}
