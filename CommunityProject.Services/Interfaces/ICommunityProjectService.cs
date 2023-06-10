using CommunityProject.Core.Models;

namespace CommunityProject.Services.Interfaces
{
    public interface ICommunityProjectService
    {
        Task<List<VCommunityProject>> GetAvailableProjectsAsync();
    }
}
