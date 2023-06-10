using CommunityProject.Core.Models;
using CommunityProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityProject.Repository.Implementations
{
    public class CommunityProjectRepository : ICommunityProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public CommunityProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<VCommunityProject>> GetAllAsync()
        {
            try
            {
                var projects = await _context.CommunityProjects.ToListAsync();
                return projects;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the community projects.", ex);
            }
        }
    }
}
