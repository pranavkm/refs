using Microsoft.Extensions.Logging;
using System.Threading;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class DisconnectListener
	{
		private class ConnectionCancellation
		{
			public ConnectionCancellation(DisconnectListener parent)
			{
				throw null;
			}

			internal CancellationToken GetCancellationToken(ulong connectionId)
			{
				throw null;
			}
		}

		internal DisconnectListener(RequestQueue requestQueue, ILogger logger)
		{
			throw null;
		}

		internal CancellationToken GetTokenForConnection(ulong connectionId)
		{
			throw null;
		}
	}
}
