using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections.Internal
{
	internal class HttpConnectionManager
	{
		private static class Log
		{
			public static void CreatedNewConnection(ILogger logger, string connectionId)
			{
				throw null;
			}

			public static void RemovedConnection(ILogger logger, string connectionId)
			{
				throw null;
			}

			public static void FailedDispose(ILogger logger, string connectionId, Exception exception)
			{
				throw null;
			}

			public static void ConnectionTimedOut(ILogger logger, string connectionId)
			{
				throw null;
			}

			public static void ConnectionReset(ILogger logger, string connectionId, Exception exception)
			{
				throw null;
			}

			public static void ScanningConnectionsFailed(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void HeartBeatStarted(ILogger logger)
			{
				throw null;
			}

			public static void HeartBeatEnded(ILogger logger)
			{
				throw null;
			}
		}

		public HttpConnectionManager(ILoggerFactory loggerFactory, IHostApplicationLifetime appLifetime, IOptions<ConnectionOptions> connectionOptions)
		{
			throw null;
		}

		public void Start()
		{
			throw null;
		}

		internal bool TryGetConnection(string id, [NotNullWhen(true)] out HttpConnectionContext? connection)
		{
			throw null;
		}

		internal HttpConnectionContext CreateConnection()
		{
			throw null;
		}

		/// <summary>
		/// Creates a connection without Pipes setup to allow saving allocations until Pipes are needed.
		/// </summary>
		/// <returns></returns>
		internal HttpConnectionContext CreateConnection(PipeOptions transportPipeOptions, PipeOptions appPipeOptions, int negotiateVersion = 0)
		{
			throw null;
		}

		public void RemoveConnection(string id)
		{
			throw null;
		}

		public void Scan()
		{
			throw null;
		}

		public void CloseConnections()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAndRemoveAsync_003Ed__16))]
		[DebuggerStepThrough]
		internal Task DisposeAndRemoveAsync(HttpConnectionContext connection, bool closeGracefully)
		{
			throw null;
		}
	}
}
