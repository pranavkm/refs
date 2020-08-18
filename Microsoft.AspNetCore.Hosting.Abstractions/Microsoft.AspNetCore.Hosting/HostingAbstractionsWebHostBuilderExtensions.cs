using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Hosting
{
	public static class HostingAbstractionsWebHostBuilderExtensions
	{
		/// <summary>
		/// Use the given configuration settings on the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configuration">The <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> containing settings to be used.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseConfiguration(this IWebHostBuilder hostBuilder, IConfiguration configuration)
		{
			throw null;
		}

		/// <summary>
		/// Set whether startup errors should be captured in the configuration settings of the web host.
		/// When enabled, startup exceptions will be caught and an error page will be returned. If disabled, startup exceptions will be propagated.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="captureStartupErrors"><c>true</c> to use startup error page; otherwise <c>false</c>.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder CaptureStartupErrors(this IWebHostBuilder hostBuilder, bool captureStartupErrors)
		{
			throw null;
		}

		/// <summary>
		/// Specify the assembly containing the startup type to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="startupAssemblyName">The name of the assembly containing the startup type.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed.")]
		public static IWebHostBuilder UseStartup(this IWebHostBuilder hostBuilder, string startupAssemblyName)
		{
			throw null;
		}

		/// <summary>
		/// Specify the server to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="server">The <see cref="T:Microsoft.AspNetCore.Hosting.Server.IServer" /> to be used.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseServer(this IWebHostBuilder hostBuilder, IServer server)
		{
			throw null;
		}

		/// <summary>
		/// Specify the environment to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="environment">The environment to host the application in.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseEnvironment(this IWebHostBuilder hostBuilder, string environment)
		{
			throw null;
		}

		/// <summary>
		/// Specify the content root directory to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="contentRoot">Path to root directory of the application.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseContentRoot(this IWebHostBuilder hostBuilder, string contentRoot)
		{
			throw null;
		}

		/// <summary>
		/// Specify the webroot directory to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="webRoot">Path to the root directory used by the web server.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseWebRoot(this IWebHostBuilder hostBuilder, string webRoot)
		{
			throw null;
		}

		/// <summary>
		/// Specify the urls the web host will listen on.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="urls">The urls the hosted application will listen on.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseUrls(this IWebHostBuilder hostBuilder, params string[] urls)
		{
			throw null;
		}

		/// <summary>
		/// Indicate whether the host should listen on the URLs configured on the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />
		/// instead of those configured on the <see cref="T:Microsoft.AspNetCore.Hosting.Server.IServer" />.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="preferHostingUrls"><c>true</c> to prefer URLs configured on the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />; otherwise <c>false</c>.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder PreferHostingUrls(this IWebHostBuilder hostBuilder, bool preferHostingUrls)
		{
			throw null;
		}

		/// <summary>
		/// Specify if startup status messages should be suppressed.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="suppressStatusMessages"><c>true</c> to suppress writing of hosting startup status messages; otherwise <c>false</c>.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder SuppressStatusMessages(this IWebHostBuilder hostBuilder, bool suppressStatusMessages)
		{
			throw null;
		}

		/// <summary>
		/// Specify the amount of time to wait for the web host to shutdown.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="timeout">The amount of time to wait for server shutdown.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseShutdownTimeout(this IWebHostBuilder hostBuilder, TimeSpan timeout)
		{
			throw null;
		}

		/// <summary>
		/// Start the web host and listen on the specified urls.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to start.</param>
		/// <param name="urls">The urls the hosted application will listen on.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHost Start(this IWebHostBuilder hostBuilder, params string[] urls)
		{
			throw null;
		}
	}
}
