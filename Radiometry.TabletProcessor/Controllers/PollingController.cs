using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Radiometry.TabletProcessor.Services;
using Radiometry.TabletProcessor.ViewModels;

namespace Radiometry.TabletProcessor.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PollingController : ControllerBase
	{
        private readonly IPollingService _pollingService;

        public PollingController(IPollingService pollingService)
        {
            _pollingService = pollingService;
        }

        [HttpGet]
        [Route("api/polling/{tabletId}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetStatus(string tabletId)
        {
            if (ModelState.IsValid)
            {
                ProcessingStatus status = await _pollingService.GetTabletStatus(tabletId);
                return new JsonResult(status);
            }

            return StatusCode(500);
        }

        [HttpPost]
        [Route("api/polling")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SubmitDataProcessing(MeasurementData data)
        {
            if (ModelState.IsValid)
            {
                bool submitted = await _pollingService.SubmitTabletProcessing(data);
                return new JsonResult(submitted);
            }

            return StatusCode(500);
        }
    }
}
