using CommunityProject.Core.Models;
using CommunityProject.Repository.Interfaces;
using CommunityProject.Services.Interfaces;

namespace CommunityProject.Services.Implementations
{
    public class CommunityProjectService : ICommunityProjectService
    {
        private readonly ICommunityProjectRepository _communityProjectRepository;

        public CommunityProjectService(ICommunityProjectRepository communityProjectRepository)
        {
            _communityProjectRepository = communityProjectRepository;
        }

        public async Task<List<VCommunityProject>> GetAvailableProjectsAsync()
        {
            try
            {
                var projects = await _communityProjectRepository.GetAllAsync();
                return projects;
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new InvalidOperationException("An error occurred while retrieving the available projects.", ex);
            }
        }
    }


}
