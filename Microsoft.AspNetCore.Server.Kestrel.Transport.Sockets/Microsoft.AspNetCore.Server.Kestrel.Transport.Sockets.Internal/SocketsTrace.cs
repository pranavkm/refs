using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal class SocketsTrace : ISocketsTrace, ILogger
	{
		public SocketsTrace(ILogger logger)
		{
			throw null;
		}

		public void ConnectionRead(string connectionId, int count)
		{
			throw null;
		}

		public void ConnectionReadFin(string connectionId)
		{
			throw null;
		}

		public void ConnectionWriteFin(string connectionId, string reason)
		{
			throw null;
		}

		public void ConnectionWrite(string connectionId, int count)
		{
			throw null;
		}

		public void ConnectionWriteCallback(string connectionId, int status)
		{
			throw null;
		}

		public void ConnectionError(string connectionId, Exception ex)
		{
			throw null;
		}

		public void ConnectionReset(string connectionId)
		{
			throw null;
		}

		public void ConnectionPause(string connectionId)
		{
			throw null;
		}

		public void ConnectionResume(string connectionId)
		{
			throw null;
		}

		public IDisposable BeginScope<TState>(TState state)
		{
			throw null;
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			throw null;
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			throw null;
		}
	}
}
