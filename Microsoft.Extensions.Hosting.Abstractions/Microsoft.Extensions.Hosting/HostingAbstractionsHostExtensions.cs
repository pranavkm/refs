using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting
{
	public static class HostingAbstractionsHostExtensions
	{
		/// <summary>
		/// Runs an application and block the calling thread until host shutdown.
		/// </summary>
		/// <param name="host">The <see cref="T:Microsoft.Extensions.Hosting.IHost" /> to run.</param>
		public static void Run(this IHost host)
		{
		}

		/// <summary>
		/// Runs an application and returns a Task that only completes when the token is triggered or shutdown is triggered.
		/// </summary>
		/// <param name="host">The <see cref="T:Microsoft.Extensions.Hosting.IHost" /> to run.</param>
		/// <param name="token">The token to trigger shutdown.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		public static Task RunAsync(this IHost host, CancellationToken token = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Starts the host synchronously.
		/// </summary>
		/// <param name="host">The <see cref="T:Microsoft.Extensions.Hosting.IHost" /> to start.</param>
		public static void Start(this IHost host)
		{
		}

		/// <summary>
		/// Attempts to gracefully stop the host with the given timeout.
		/// </summary>
		/// <param name="host">The <see cref="T:Microsoft.Extensions.Hosting.IHost" /> to stop.</param>
		/// <param name="timeout">The timeout for stopping gracefully. Once expired the
		/// server may terminate any remaining active connections.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		public static Task StopAsync(this IHost host, TimeSpan timeout)
		{
			throw null;
		}

		/// <summary>
		/// Block the calling thread until shutdown is triggered via Ctrl+C or SIGTERM.
		/// </summary>
		/// <param name="host">The running <see cref="T:Microsoft.Extensions.Hosting.IHost" />.</param>
		public static void WaitForShutdown(this IHost host)
		{
		}

		/// <summary>
		/// Returns a Task that completes when shutdown is triggered via the given token.
		/// </summary>
		/// <param name="host">The running <see cref="T:Microsoft.Extensions.Hosting.IHost" />.</param>
		/// <param name="token">The token to trigger shutdown.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		public static Task WaitForShutdownAsync(this IHost host, CancellationToken token = default(CancellationToken))
		{
			throw null;
		}
	}
}
