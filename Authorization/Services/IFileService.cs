using System.Threading.Tasks;

namespace Authorization.Services
{
	public interface IFileService
	{
		string FileName { get; }

		Task<int> GetMeasurement(int x, int y);

		Task<bool> SaveMeasurement(int x, int y, int value);

		Task EditMeasurement(int x, int y, int newValue);

		Task<bool> DeleteMeasurement(int x, int y);
	}
}
