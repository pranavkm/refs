using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	internal class DefaultHealthCheckService : HealthCheckService
	{
		internal static class EventIds
		{
			public static readonly EventId HealthCheckProcessingBegin;

			public static readonly EventId HealthCheckProcessingEnd;

			public static readonly EventId HealthCheckBegin;

			public static readonly EventId HealthCheckEnd;

			public static readonly EventId HealthCheckError;

			public static readonly EventId HealthCheckData;
		}

		private static class Log
		{
			public static void HealthCheckProcessingBegin(ILogger logger)
			{
				throw null;
			}

			public static void HealthCheckProcessingEnd(ILogger logger, HealthStatus status, TimeSpan duration)
			{
				throw null;
			}

			public static void HealthCheckBegin(ILogger logger, HealthCheckRegistration registration)
			{
				throw null;
			}

			public static void HealthCheckEnd(ILogger logger, HealthCheckRegistration registration, HealthReportEntry entry, TimeSpan duration)
			{
				throw null;
			}

			public static void HealthCheckError(ILogger logger, HealthCheckRegistration registration, Exception exception, TimeSpan duration)
			{
				throw null;
			}

			public static void HealthCheckData(ILogger logger, HealthCheckRegistration registration, HealthReportEntry entry)
			{
				throw null;
			}
		}

		internal class HealthCheckDataLogValue : IReadOnlyList<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, object>>
		{
			public KeyValuePair<string, object> this[int index]
			{
				get
				{
					throw null;
				}
			}

			public int Count
			{
				get
				{
					throw null;
				}
			}

			public HealthCheckDataLogValue(string name, IReadOnlyDictionary<string, object> values)
			{
				throw null;
			}

			public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
			{
				throw null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw null;
			}

			public override string ToString()
			{
				throw null;
			}
		}

		public DefaultHealthCheckService(IServiceScopeFactory scopeFactory, IOptions<HealthCheckServiceOptions> options, ILogger<DefaultHealthCheckService> logger)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CCheckHealthAsync_003Ed__4))]
		[DebuggerStepThrough]
		public override Task<HealthReport> CheckHealthAsync(Func<HealthCheckRegistration, bool>? predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
