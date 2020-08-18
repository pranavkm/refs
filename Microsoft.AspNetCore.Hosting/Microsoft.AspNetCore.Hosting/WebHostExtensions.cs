using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Hosting
{
	public static class WebHostExtensions
	{
		/// <summary>
		/// Attempts to gracefully stop the host with the given timeout.
		/// </summary>
		/// <param name="host"></param>
		/// <param name="timeout">The timeout for stopping gracefully. Once expired the
		/// server may terminate any remaining active connections.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> stops.</returns>
		[AsyncStateMachine(typeof(_003CStopAsync_003Ed__0))]
		[DebuggerStepThrough]
		public static Task StopAsync(this IWebHost host, TimeSpan timeout)
		{
			throw null;
		}

		/// <summary>
		/// Block the calling thread until shutdown is triggered via Ctrl+C or SIGTERM.
		/// </summary>
		/// <param name="host">The running <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />.</param>
		public static void WaitForShutdown(this IWebHost host)
		{
			throw null;
		}

		/// <summary>
		/// Returns a Task that completes when shutdown is triggered via the given token, Ctrl+C or SIGTERM.
		/// </summary>
		/// <param name="host">The running <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />.</param>
		/// <param name="token">The token to trigger shutdown.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when shutdown is triggered via Ctrl+C or SIGTERM.</returns>
		[AsyncStateMachine(typeof(_003CWaitForShutdownAsync_003Ed__2))]
		[DebuggerStepThrough]
		public static Task WaitForShutdownAsync(this IWebHost host, CancellationToken token = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Runs a web application and block the calling thread until host shutdown.
		/// </summary>
		/// <param name="host">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> to run.</param>
		public static void Run(this IWebHost host)
		{
			throw null;
		}

		/// <summary>
		/// Runs a web application and returns a Task that only completes when the token is triggered or shutdown is triggered.
		/// </summary>
		/// <param name="host">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> to run.</param>
		/// <param name="token">The token to trigger shutdown.</param>
		[AsyncStateMachine(typeof(_003CRunAsync_003Ed__4))]
		[DebuggerStepThrough]
		public static Task RunAsync(this IWebHost host, CancellationToken token = default(CancellationToken))
		{
			throw null;
		}
	}
}
