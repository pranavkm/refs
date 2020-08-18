using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Allows consumers to perform cleanup during a graceful shutdown.
	/// </summary>
	internal class ApplicationLifetime : IApplicationLifetime, Microsoft.Extensions.Hosting.IApplicationLifetime, IHostApplicationLifetime
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
		/// Request may still be in flight. Shutdown will block until this event completes.
		/// </summary>
		public CancellationToken ApplicationStopping
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

		public ApplicationLifetime(ILogger<ApplicationLifetime> logger)
		{
			throw null;
		}

		/// <summary>
		/// Signals the ApplicationStopping event and blocks until it completes.
		/// </summary>
		public void StopApplication()
		{
			throw null;
		}

		/// <summary>
		/// Signals the ApplicationStarted event and blocks until it completes.
		/// </summary>
		public void NotifyStarted()
		{
			throw null;
		}

		/// <summary>
		/// Signals the ApplicationStopped event and blocks until it completes.
		/// </summary>
		public void NotifyStopped()
		{
			throw null;
		}
	}
}
