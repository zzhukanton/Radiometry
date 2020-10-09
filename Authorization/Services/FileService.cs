using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.Services
{
	public class FileService : IFileService
	{
		public string FileName => throw new NotImplementedException();



		public Task<bool> DeleteMeasurement(int x, int y)
		{
			throw new NotImplementedException();
		}

		public Task EditMeasurement(int x, int y, int newValue)
		{
			throw new NotImplementedException();
		}

		public Task<int> GetMeasurement(int x, int y)
		{
			throw new NotImplementedException();
		}

		public Task<bool> SaveMeasurement(int x, int y, int value)
		{
			throw new NotImplementedException();
		}
	}
}
