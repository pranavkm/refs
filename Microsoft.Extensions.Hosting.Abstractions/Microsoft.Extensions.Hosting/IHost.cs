using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// A program abstraction.
	/// </summary>
	public interface IHost : IDisposable
	{
		/// <summary>
		/// The programs configured services.
		/// </summary>
		IServiceProvider Services
		{
			get;
		}

		/// <summary>
		/// Start the program.
		/// </summary>
		/// <param name="cancellationToken">Used to abort program start.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that will be completed when the <see cref="T:Microsoft.Extensions.Hosting.IHost" /> starts.</returns>
		Task StartAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Attempts to gracefully stop the program.
		/// </summary>
		/// <param name="cancellationToken">Used to indicate when stop should no longer be graceful.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that will be completed when the <see cref="T:Microsoft.Extensions.Hosting.IHost" /> stops.</returns>
		Task StopAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
