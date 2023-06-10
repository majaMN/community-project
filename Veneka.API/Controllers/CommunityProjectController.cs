using Microsoft.AspNetCore.Mvc;
using CommunityProject.Services.Interfaces;

namespace CommunityProject.API.Controllers
{
    [ApiController]
    [Route("api/community-projects")]
    public class CommunityProjectController : ControllerBase
    {
        private readonly ICommunityProjectService _communityProjectService;

        public CommunityProjectController(ICommunityProjectService communityProjectService)
        {
            _communityProjectService = communityProjectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAvailableProjects()
        {
            try
            {
                var projects = await _communityProjectService.GetAvailableProjectsAsync();
                return Ok(projects);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "An error occurred while retrieving the available projects.");
            }
        }
    }
}
