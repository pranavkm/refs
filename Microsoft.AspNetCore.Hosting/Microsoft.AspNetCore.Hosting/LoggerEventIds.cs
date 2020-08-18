using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Hosting
{
	internal static class LoggerEventIds
	{
		public static readonly EventId RequestStarting;

		public static readonly EventId RequestFinished;

		public static readonly EventId Starting;

		public static readonly EventId Started;

		public static readonly EventId Shutdown;

		public static readonly EventId ApplicationStartupException;

		public static readonly EventId ApplicationStoppingException;

		public static readonly EventId ApplicationStoppedException;

		public static readonly EventId HostedServiceStartException;

		public static readonly EventId HostedServiceStopException;

		public static readonly EventId HostingStartupAssemblyException;

		public static readonly EventId ServerShutdownException;
	}
}
