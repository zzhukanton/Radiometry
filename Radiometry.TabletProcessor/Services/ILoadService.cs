using System.Threading.Tasks;

namespace Radiometry.TabletProcessor.Services
{
	public interface ILoadService
	{
		Task<string> BuildMap(string tabletId);

		Task<string> BuildAnomaly(string tabletId);

		Task<string> BuildData(string tabletId);

		Task<string> BuildProfile(string tabletId);
	}
}
