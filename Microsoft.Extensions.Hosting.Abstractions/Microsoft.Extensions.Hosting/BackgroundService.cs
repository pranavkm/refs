using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Base class for implementing a long running <see cref="T:Microsoft.Extensions.Hosting.IHostedService" />.
	/// </summary>
	public abstract class BackgroundService : IHostedService, IDisposable
	{
		public virtual void Dispose()
		{
		}

		/// <summary>
		/// This method is called when the <see cref="T:Microsoft.Extensions.Hosting.IHostedService" /> starts. The implementation should return a task that represents
		/// the lifetime of the long running operation(s) being performed.
		/// </summary>
		/// <param name="stoppingToken">Triggered when <see cref="M:Microsoft.Extensions.Hosting.IHostedService.StopAsync(System.Threading.CancellationToken)" /> is called.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the long running operations.</returns>
		protected abstract Task ExecuteAsync(CancellationToken stoppingToken);

		/// <summary>
		/// Triggered when the application host is ready to start the service.
		/// </summary>
		/// <param name="cancellationToken">Indicates that the start process has been aborted.</param>
		public virtual Task StartAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Triggered when the application host is performing a graceful shutdown.
		/// </summary>
		/// <param name="cancellationToken">Indicates that the shutdown process should no longer be graceful.</param>
		public virtual Task StopAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
