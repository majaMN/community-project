using CommunityProject.Core.Models;

namespace CommunityProject.Repository.Interfaces
{
    public interface ICommunityProjectRepository
    {
        Task<List<VCommunityProject>> GetAllAsync();
    }

}
