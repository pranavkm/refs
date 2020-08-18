using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal static class HostingLoggerExtensions
	{
		private class HostingLogScope : IReadOnlyList<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, object>>
		{
			public int Count
			{
				get
				{
					throw null;
				}
			}

			public KeyValuePair<string, object> this[int index]
			{
				get
				{
					throw null;
				}
			}

			public HostingLogScope(HttpContext httpContext)
			{
				throw null;
			}

			public override string ToString()
			{
				throw null;
			}

			[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__9))]
			public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
			{
				throw null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw null;
			}
		}

		public static IDisposable RequestScope(this ILogger logger, HttpContext httpContext)
		{
			throw null;
		}

		public static void ApplicationError(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void HostingStartupAssemblyError(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void ApplicationError(this ILogger logger, EventId eventId, string message, Exception exception)
		{
			throw null;
		}

		public static void Starting(this ILogger logger)
		{
			throw null;
		}

		public static void Started(this ILogger logger)
		{
			throw null;
		}

		public static void Shutdown(this ILogger logger)
		{
			throw null;
		}

		public static void ServerShutdownException(this ILogger logger, Exception ex)
		{
			throw null;
		}
	}
}
