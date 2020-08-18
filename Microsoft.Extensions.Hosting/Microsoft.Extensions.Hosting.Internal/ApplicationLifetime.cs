using Microsoft.Extensions.Logging;
using System.Threading;

namespace Microsoft.Extensions.Hosting.Internal
{
	/// <summary>
	/// Allows consumers to perform cleanup during a graceful shutdown.
	/// </summary>
	public class ApplicationLifetime : IApplicationLifetime, IHostApplicationLifetime
	{
		/// <summary>
		/// Triggered when the application host has fully started and is about to wait
		/// for a graceful shutdown.
		/// </summary>
		public CancellationToken ApplicationStarted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Triggered when the application host is performing a graceful shutdown.
		/// All requests should be complete at this point. Shutdown will block
		/// until this event completes.
		/// </summary>
		public CancellationToken ApplicationStopped
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Triggered when the application host is performing a graceful shutdown.
		/// Request may still be in flight. Shutdown will block until this event completes.
		/// </summary>
		public CancellationToken ApplicationStopping
		{
			get
			{
				throw null;
			}
		}

		public ApplicationLifetime(ILogger<ApplicationLifetime> logger)
		{
		}

		/// <summary>
		/// Signals the ApplicationStarted event and blocks until it completes.
		/// </summary>
		public void NotifyStarted()
		{
		}

		/// <summary>
		/// Signals the ApplicationStopped event and blocks until it completes.
		/// </summary>
		public void NotifyStopped()
		{
		}

		/// <summary>
		/// Signals the ApplicationStopping event and blocks until it completes.
		/// </summary>
		public void StopApplication()
		{
		}
	}
}
