using Radiometry.TabletProcessor.ViewModels;
using System;
using System.Threading.Tasks;

namespace Radiometry.TabletProcessor.Services
{
	public class PollingService : IPollingService
	{
		private readonly TabletProcessorContext context;

		public PollingService(TabletProcessorContext context)
		{
			this.context = context;
		}

		public Task<ProcessingStatus> GetTabletStatus(string tabletId)
		{
			var tablet = context.Tablets.Find(tabletId);

			context.SaveChanges();

			return Task.FromResult(new ProcessingStatus
			{
				TabletId = tablet.TabletId,
				IsProcessed = tablet.IsProcessed
			});
		}

		public Task<bool> SubmitTabletProcessing(MeasurementData data)
		{
			var tablet = context.Tablets.Find(data.TabletId);
			var profile = context.Profiles.Find(data.TabletId);
			var _data = context.Datas.Find(profile.ProfileId);

			Array.ForEach(data.TabletData, profileData =>
			{
				var data = context.Datas.Add(new Models.Data
				{
					DataArray = profileData,
					ProfileId = profile.ProfileId
				});
			});

			return Task.FromResult(context.SaveChanges() != -1);
		}
	}
}
