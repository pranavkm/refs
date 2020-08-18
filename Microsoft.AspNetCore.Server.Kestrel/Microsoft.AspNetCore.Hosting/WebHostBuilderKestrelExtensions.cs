using Microsoft.AspNetCore.Server.Kestrel.Core;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	public static class WebHostBuilderKestrelExtensions
	{
		/// <summary>
		/// Specify Kestrel as the server to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <returns>
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder.
		/// </returns>
		public static IWebHostBuilder UseKestrel(this IWebHostBuilder hostBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Specify Kestrel as the server to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <param name="options">
		/// A callback to configure Kestrel options.
		/// </param>
		/// <returns>
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder.
		/// </returns>
		public static IWebHostBuilder UseKestrel(this IWebHostBuilder hostBuilder, Action<KestrelServerOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Configures Kestrel options but does not register an IServer. See <see cref="M:Microsoft.AspNetCore.Hosting.WebHostBuilderKestrelExtensions.UseKestrel(Microsoft.AspNetCore.Hosting.IWebHostBuilder)" />.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <param name="options">
		/// A callback to configure Kestrel options.
		/// </param>
		/// <returns>
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder.
		/// </returns>
		public static IWebHostBuilder ConfigureKestrel(this IWebHostBuilder hostBuilder, Action<KestrelServerOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Specify Kestrel as the server to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <param name="configureOptions">A callback to configure Kestrel options.</param>
		/// <returns>
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder.
		/// </returns>
		public static IWebHostBuilder UseKestrel(this IWebHostBuilder hostBuilder, Action<WebHostBuilderContext, KestrelServerOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Configures Kestrel options but does not register an IServer. See <see cref="M:Microsoft.AspNetCore.Hosting.WebHostBuilderKestrelExtensions.UseKestrel(Microsoft.AspNetCore.Hosting.IWebHostBuilder)" />.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <param name="configureOptions">A callback to configure Kestrel options.</param>
		/// <returns>
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder.
		/// </returns>
		public static IWebHostBuilder ConfigureKestrel(this IWebHostBuilder hostBuilder, Action<WebHostBuilderContext, KestrelServerOptions> configureOptions)
		{
			throw null;
		}
	}
}
