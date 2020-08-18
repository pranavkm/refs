using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal interface ISocketsTrace : ILogger
	{
		void ConnectionReadFin(string connectionId);

		void ConnectionWriteFin(string connectionId, string reason);

		void ConnectionError(string connectionId, Exception ex);

		void ConnectionReset(string connectionId);

		void ConnectionPause(string connectionId);

		void ConnectionResume(string connectionId);
	}
}
