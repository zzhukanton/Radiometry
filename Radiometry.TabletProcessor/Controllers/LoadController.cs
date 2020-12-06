using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Radiometry.TabletProcessor.Services;

namespace Radiometry.TabletProcessor.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoadController : ControllerBase
	{
        private readonly ILoadService _loadService;
        private readonly ChartProcessor processor;

        public LoadController(ILoadService loadService)
        {
            _loadService = loadService;
            processor = new ChartProcessor();
        }

        [HttpGet]
        [Route("api/{tabletId}/map")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoadMap(string tabletId)
        {
            if (ModelState.IsValid)
            {
                string fileName = await _loadService.BuildMap(tabletId);
                return File(fileName, "image/png");
            }

            return StatusCode(500);
        }

        [HttpGet]
        [Route("api/{tabletId}/anomaly")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoadAnomaly(string tabletId)
        {
            if (ModelState.IsValid)
            {
                string fileName = await _loadService.BuildAnomaly(tabletId);
                return File(fileName, "image/png");
            }

            return StatusCode(500);
        }

        [HttpGet]
        [Route("api/{tabletId}/data")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoadDataFile(string tabletId)
        {
            if (ModelState.IsValid)
            {
                string fileName = await _loadService.BuildData(tabletId);
                return File(fileName, "text/plain");
            }

            return StatusCode(500);
        }

        [HttpGet]
        [Route("api/{tabletId}/profiles")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoadAllProfiles(string tabletId)
        {
            if (ModelState.IsValid)
            {
                string fileName = await _loadService.BuildProfile(tabletId);
                return File(fileName, "image/png");
            }

            return StatusCode(500);
        }
    }
}
