using Microsoft.Extensions.Internal;
using System.Diagnostics.Tracing;

namespace Microsoft.AspNetCore.Http.Connections.Internal
{
	internal class HttpConnectionsEventSource : EventSource
	{
		public static readonly HttpConnectionsEventSource Log;

		internal HttpConnectionsEventSource()
		{
			throw null;
		}

		internal HttpConnectionsEventSource(string eventSourceName)
		{
			throw null;
		}

		[NonEvent]
		public void ConnectionStop(string connectionId, ValueStopwatch timer)
		{
			throw null;
		}

		[Event(1, Level = EventLevel.Informational, Message = "Started connection '{0}'.")]
		public ValueStopwatch ConnectionStart(string connectionId)
		{
			throw null;
		}

		[Event(3, Level = EventLevel.Informational, Message = "Connection '{0}' timed out.")]
		public void ConnectionTimedOut(string connectionId)
		{
			throw null;
		}

		protected override void OnEventCommand(EventCommandEventArgs command)
		{
			throw null;
		}
	}
}
