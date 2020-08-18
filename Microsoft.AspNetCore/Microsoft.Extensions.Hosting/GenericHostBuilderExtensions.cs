using Microsoft.AspNetCore.Hosting;
using System;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Extension methods for configuring the IWebHostBuilder.
	/// </summary>
	public static class GenericHostBuilderExtensions
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> class with pre-configured defaults.
		/// </summary>
		/// <remarks>
		///   The following defaults are applied to the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />:
		///     use Kestrel as the web server and configure it using the application's configuration providers,
		///     configure the <see cref="P:Microsoft.AspNetCore.Hosting.IWebHostEnvironment.WebRootFileProvider" /> to map static web assets when <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" /> is 'Development' using the entry assembly,
		///     adds the HostFiltering middleware,
		///     adds the ForwardedHeaders middleware if ASPNETCORE_FORWARDEDHEADERS_ENABLED=true,
		///     and enable IIS integration.
		/// </remarks>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> instance to configure</param>
		/// <param name="configure">The configure callback</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder ConfigureWebHostDefaults(this IHostBuilder builder, Action<IWebHostBuilder> configure)
		{
			throw null;
		}
	}
}
