using Microsoft.AspNetCore.Http.Features;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Represents a configured web host.
	/// </summary>
	public interface IWebHost : IDisposable
	{
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Http.Features.IFeatureCollection" /> exposed by the configured server.
		/// </summary>
		IFeatureCollection ServerFeatures
		{
			get;
		}

		/// <summary>
		/// The <see cref="T:System.IServiceProvider" /> for the host.
		/// </summary>
		IServiceProvider Services
		{
			get;
		}

		/// <summary>
		/// Starts listening on the configured addresses.
		/// </summary>
		void Start();

		/// <summary>
		/// Starts listening on the configured addresses.
		/// </summary>
		/// <param name="cancellationToken">Used to abort program start.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> starts.</returns>
		Task StartAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Attempt to gracefully stop the host.
		/// </summary>
		/// <param name="cancellationToken">Used to indicate when stop should no longer be graceful.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> stops.</returns>
		Task StopAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
