using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	internal sealed class HealthCheckPublisherHostedService : IHostedService
	{
		internal static class EventIds
		{
			public static readonly EventId HealthCheckPublisherProcessingBegin;

			public static readonly EventId HealthCheckPublisherProcessingEnd;

			public static readonly EventId HealthCheckPublisherProcessingError;

			public static readonly EventId HealthCheckPublisherBegin;

			public static readonly EventId HealthCheckPublisherEnd;

			public static readonly EventId HealthCheckPublisherError;

			public static readonly EventId HealthCheckPublisherTimeout;
		}

		private static class Logger
		{
			public static void HealthCheckPublisherProcessingBegin(ILogger logger)
			{
				throw null;
			}

			public static void HealthCheckPublisherProcessingEnd(ILogger logger, TimeSpan duration, Exception? exception = null)
			{
				throw null;
			}

			public static void HealthCheckPublisherBegin(ILogger logger, IHealthCheckPublisher publisher)
			{
				throw null;
			}

			public static void HealthCheckPublisherEnd(ILogger logger, IHealthCheckPublisher publisher, TimeSpan duration)
			{
				throw null;
			}

			public static void HealthCheckPublisherError(ILogger logger, IHealthCheckPublisher publisher, TimeSpan duration, Exception exception)
			{
				throw null;
			}

			public static void HealthCheckPublisherTimeout(ILogger logger, IHealthCheckPublisher publisher, TimeSpan duration)
			{
				throw null;
			}
		}

		internal bool IsStopping
		{
			get
			{
				throw null;
			}
		}

		internal bool IsTimerRunning
		{
			get
			{
				throw null;
			}
		}

		public HealthCheckPublisherHostedService(HealthCheckService healthCheckService, IOptions<HealthCheckPublisherOptions> options, ILogger<HealthCheckPublisherHostedService> logger, IEnumerable<IHealthCheckPublisher> publishers)
		{
			throw null;
		}

		public Task StartAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public Task StopAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		internal void CancelToken()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CRunAsync_003Ed__16))]
		[DebuggerStepThrough]
		internal Task RunAsync()
		{
			throw null;
		}
	}
}
