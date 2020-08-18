using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal sealed class HostingEventSource : EventSource
	{
		public static readonly HostingEventSource Log;

		internal HostingEventSource()
		{
			throw null;
		}

		internal HostingEventSource(string eventSourceName)
		{
			throw null;
		}

		[Event(1, Level = EventLevel.Informational)]
		public void HostStart()
		{
			throw null;
		}

		[Event(2, Level = EventLevel.Informational)]
		public void HostStop()
		{
			throw null;
		}

		[Event(3, Level = EventLevel.Informational)]
		public void RequestStart(string method, string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Event(4, Level = EventLevel.Informational)]
		public void RequestStop()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Event(5, Level = EventLevel.Error)]
		public void UnhandledException()
		{
			throw null;
		}

		internal void RequestFailed()
		{
			throw null;
		}

		protected override void OnEventCommand(EventCommandEventArgs command)
		{
			throw null;
		}
	}
}
