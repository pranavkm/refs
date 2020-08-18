using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;

namespace Microsoft.AspNetCore
{
	/// <summary>
	/// Provides convenience methods for creating instances of <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> and <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> with pre-configured defaults.
	/// </summary>
	public static class WebHost
	{
		/// <summary>
		/// Initializes and starts a new <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> with pre-configured defaults.
		/// See <see cref="M:Microsoft.AspNetCore.WebHost.CreateDefaultBuilder" /> for details.
		/// </summary>
		/// <param name="app">A delegate that handles requests to the application.</param>
		/// <returns>A started <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> that hosts the application.</returns>
		public static IWebHost Start(RequestDelegate app)
		{
			throw null;
		}

		/// <summary>
		/// Initializes and starts a new <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> with pre-configured defaults.
		/// See <see cref="M:Microsoft.AspNetCore.WebHost.CreateDefaultBuilder" /> for details.
		/// </summary>
		/// <param name="url">The URL the hosted application will listen on.</param>
		/// <param name="app">A delegate that handles requests to the application.</param>
		/// <returns>A started <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> that hosts the application.</returns>
		public static IWebHost Start(string? url, RequestDelegate app)
		{
			throw null;
		}

		/// <summary>
		/// Initializes and starts a new <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> with pre-configured defaults.
		/// See <see cref="M:Microsoft.AspNetCore.WebHost.CreateDefaultBuilder" /> for details.
		/// </summary>
		/// <param name="routeBuilder">A delegate that configures the router for handling requests to the application.</param>
		/// <returns>A started <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> that hosts the application.</returns>
		public static IWebHost Start(Action<IRouteBuilder> routeBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Initializes and starts a new <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> with pre-configured defaults.
		/// See <see cref="M:Microsoft.AspNetCore.WebHost.CreateDefaultBuilder" /> for details.
		/// </summary>
		/// <param name="url">The URL the hosted application will listen on.</param>
		/// <param name="routeBuilder">A delegate that configures the router for handling requests to the application.</param>
		/// <returns>A started <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> that hosts the application.</returns>
		public static IWebHost Start(string? url, Action<IRouteBuilder> routeBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Initializes and starts a new <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> with pre-configured defaults.
		/// See <see cref="M:Microsoft.AspNetCore.WebHost.CreateDefaultBuilder" /> for details.
		/// </summary>
		/// <param name="app">The delegate that configures the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A started <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> that hosts the application.</returns>
		public static IWebHost StartWith(Action<IApplicationBuilder> app)
		{
			throw null;
		}

		/// <summary>
		/// Initializes and starts a new <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> with pre-configured defaults.
		/// See <see cref="M:Microsoft.AspNetCore.WebHost.CreateDefaultBuilder" /> for details.
		/// </summary>
		/// <param name="url">The URL the hosted application will listen on.</param>
		/// <param name="app">The delegate that configures the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A started <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> that hosts the application.</returns>
		public static IWebHost StartWith(string? url, Action<IApplicationBuilder> app)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilder" /> class with pre-configured defaults.
		/// </summary>
		/// <remarks>
		///   The following defaults are applied to the returned <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilder" />:
		///     use Kestrel as the web server and configure it using the application's configuration providers,
		///     set the <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.ContentRootPath" /> to the result of <see cref="M:System.IO.Directory.GetCurrentDirectory" />,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from 'appsettings.json' and 'appsettings.[<see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" />].json',
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from User Secrets when <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" /> is 'Development' using the entry assembly,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from environment variables,
		///     configure the <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> to log to the console and debug output,
		///     adds the HostFiltering middleware,
		///     adds the ForwardedHeaders middleware if ASPNETCORE_FORWARDEDHEADERS_ENABLED=true,
		///     and enable IIS integration.
		/// </remarks>
		/// <returns>The initialized <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder CreateDefaultBuilder()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilder" /> class with pre-configured defaults.
		/// </summary>
		/// <remarks>
		///   The following defaults are applied to the returned <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilder" />:
		///     use Kestrel as the web server and configure it using the application's configuration providers,
		///     set the <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.ContentRootPath" /> to the result of <see cref="M:System.IO.Directory.GetCurrentDirectory" />,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from 'appsettings.json' and 'appsettings.[<see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" />].json',
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from User Secrets when <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" /> is 'Development' using the entry assembly,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from environment variables,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from supplied command line args,
		///     configure the <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> to log to the console and debug output,
		///     configure the <see cref="P:Microsoft.AspNetCore.Hosting.IWebHostEnvironment.WebRootFileProvider" /> to map static web assets when <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" /> is 'Development' using the entry assembly,
		///     adds the HostFiltering middleware,
		///     adds the ForwardedHeaders middleware if ASPNETCORE_FORWARDEDHEADERS_ENABLED=true,
		///     and enable IIS integration.
		/// </remarks>
		/// <param name="args">The command line args.</param>
		/// <returns>The initialized <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder CreateDefaultBuilder(string[]? args)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilder" /> class with pre-configured defaults using typed Startup.
		/// </summary>
		/// <remarks>
		///   The following defaults are applied to the returned <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilder" />:
		///     use Kestrel as the web server and configure it using the application's configuration providers,
		///     set the <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.ContentRootPath" /> to the result of <see cref="M:System.IO.Directory.GetCurrentDirectory" />,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from 'appsettings.json' and 'appsettings.[<see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" />].json',
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from User Secrets when <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" /> is 'Development' using the entry assembly,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from environment variables,
		///     load <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> from supplied command line args,
		///     configure the <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> to log to the console and debug output,
		///     enable IIS integration.
		/// </remarks>
		/// <typeparam name="TStartup">The type containing the startup methods for the application.</typeparam>
		/// <param name="args">The command line args.</param>
		/// <returns>The initialized <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder CreateDefaultBuilder<TStartup>(string[] args) where TStartup : class
		{
			throw null;
		}
	}
}
