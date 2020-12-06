using Radiometry.TabletProcessor.ViewModels;
using System.Threading.Tasks;

namespace Radiometry.TabletProcessor.Services
{
	public interface IPollingService
	{
		Task<ProcessingStatus> GetTabletStatus(string tabletId);

		Task<bool> SubmitTabletProcessing(MeasurementData data);
	}
}
