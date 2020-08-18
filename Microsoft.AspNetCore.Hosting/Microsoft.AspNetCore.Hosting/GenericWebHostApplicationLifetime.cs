using Microsoft.Extensions.Hosting;
using System.Threading;

namespace Microsoft.AspNetCore.Hosting
{
	internal class GenericWebHostApplicationLifetime : IApplicationLifetime
	{
		public CancellationToken ApplicationStarted
		{
			get
			{
				throw null;
			}
		}

		public CancellationToken ApplicationStopping
		{
			get
			{
				throw null;
			}
		}

		public CancellationToken ApplicationStopped
		{
			get
			{
				throw null;
			}
		}

		public GenericWebHostApplicationLifetime(IHostApplicationLifetime applicationLifetime)
		{
			throw null;
		}

		public void StopApplication()
		{
			throw null;
		}
	}
}
