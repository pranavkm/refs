using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting
{
	public static class HostingAbstractionsHostBuilderExtensions
	{
		/// <summary>
		/// Builds and starts the host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to start.</param>
		/// <returns>The started <see cref="T:Microsoft.Extensions.Hosting.IHost" />.</returns>
		public static IHost Start(this IHostBuilder hostBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Builds and starts the host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to start.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that can be used to cancel the start.</param>
		/// <returns>The started <see cref="T:Microsoft.Extensions.Hosting.IHost" />.</returns>
		public static Task<IHost> StartAsync(this IHostBuilder hostBuilder, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
