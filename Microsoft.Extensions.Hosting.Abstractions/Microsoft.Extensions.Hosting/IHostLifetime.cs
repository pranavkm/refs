using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting
{
	public interface IHostLifetime
	{
		/// <summary>
		/// Called from <see cref="M:Microsoft.Extensions.Hosting.IHost.StopAsync(System.Threading.CancellationToken)" /> to indicate that the host is stopping and it's time to shut down.
		/// </summary>
		/// <param name="cancellationToken">Used to indicate when stop should no longer be graceful.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" />.</returns>
		Task StopAsync(CancellationToken cancellationToken);

		/// <summary>
		/// Called at the start of <see cref="M:Microsoft.Extensions.Hosting.IHost.StartAsync(System.Threading.CancellationToken)" /> which will wait until it's complete before
		/// continuing. This can be used to delay startup until signaled by an external event.
		/// </summary>
		/// <param name="cancellationToken">Used to abort program start.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" />.</returns>
		Task WaitForStartAsync(CancellationToken cancellationToken);
	}
}
