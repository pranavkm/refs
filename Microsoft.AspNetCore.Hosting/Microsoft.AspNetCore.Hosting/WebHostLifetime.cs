using System;
using System.Threading;

namespace Microsoft.AspNetCore.Hosting
{
	internal class WebHostLifetime : IDisposable
	{
		public WebHostLifetime(CancellationTokenSource cts, ManualResetEventSlim resetEvent, string shutdownMessage)
		{
			throw null;
		}

		internal void SetExitedGracefully()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
